using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;


namespace Eff2EmtGUI
{
    public partial class Form1 : Form
    {
        // Can be customized with any available text editors. Will be checked from top to bottom, and the first one found will be execute for an .emt file.
        public static List<string> TextEditors = new List<string>()
        {
            "C:\\Program Files (x86)\\Notepad++\\notepad++.exe",
            "C:\\Program Files\\Notepad++\\notepad++.exe",
            "C:\\Windows\notepad.exe"
        };

        public string fileName;
        public int gridRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textEQFolder.Text = Properties.Settings.Default.EQFolder;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.EQFolder = textEQFolder.Text;

            Properties.Settings.Default.Save();
        }

        public static Dictionary<int, string> HardCodedSoundFiles = new Dictionary<int, string>()
        {
            {  39, "death_me" },
            { 143, "thunder1" },
            { 144, "thunder2" },
            { 158, "wind_lp1" },
            { 159, "rainloop" },
            { 160, "torch_lp" },
            { 161, "watundlp" }
        };

        public static Dictionary<int, string> DefaultMusicFiles = new Dictionary<int, string>()
        {
            {  1, "bothunder.mp3" },
            {  2, "codecay.mp3" },
            {  3, "combattheme1.mp3" },
            {  4, "combattheme2.mp3" },
            {  5, "deaththeme.mp3" },
            {  6, "eqtheme.mp3" },
            {  7, "hohonor.mp3" },
            {  8, "poair.mp3" },
            {  9, "podisease.mp3" },
            { 10, "poearth.mp3" },
            { 11, "pofire.mp3" },
            { 12, "poinnovation.mp3" },
            { 13, "pojustice.mp3" },
            { 14, "poknowledge.mp3" },
            { 15, "ponightmare.mp3" },
            { 16, "postorms.mp3" },
            { 17, "potactics.mp3" },
            { 18, "potime.mp3" },
            { 19, "potorment.mp3" },
            { 20, "potranquility.mp3" },
            { 21, "povalor.mp3" },
            { 22, "powar.mp3" },
            { 23, "powater.mp3" },
            { 24, "solrotower.mp3" }
        };

        public struct EffSoundEntry
        {
            public Int32 UnkRef00;
            public Int32 UnkRef04;
            public Int32 Reserved;
            public Int32 Sequence;
            public float X;
            public float Y;
            public float Z;
            public float Radius;
            public Int32 Cooldown1;
            public Int32 Cooldown2;
            public Int32 RandomDelay;
            public Int32 Unk44;
            public Int32 SoundID1;
            public Int32 SoundID2;
            public Byte SoundType;
            public Byte UnkPad57;
            public Byte UnkPad58;
            public Byte UnkPad59;
            public Int32 AsDistance;
            public Int32 UnkRange64;
            public Int32 FadeOutMS;
            public Int32 UnkRange72;
            public Int32 FullVolRange;
            public Int32 UnkRange80;
        };


        private void CheckIfReady()
        {
            labelZonesSelected.Text = listZoneEffs.CheckedItems.Count.ToString();
            labelZoneCount.Text = listZoneEffs.Items.Count.ToString();
            
            buttonConvert.Enabled = (listZoneEffs.CheckedItems.Count > 0);
        }

        private void CheckZoneList()
        {
            listZoneEffs.Items.Clear();
            
            if (Directory.Exists(textEQFolder.Text))
            {
                FileInfo[] _files = new DirectoryInfo(textEQFolder.Text).GetFiles("*_sounds.eff");

                foreach (FileInfo _file in _files)
                {
                    listZoneEffs.Items.Add(_file.Name.Substring(0, _file.Name.Length - "_sounds.eff".Length));
                }
            }

            CheckIfReady();
        }

        private void textEQFolder_TextChanged(object sender, EventArgs e)
        {
            CheckZoneList();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }

            Array _files = (Array)e.Data.GetData(DataFormats.FileDrop);

            if ((_files == null) || (_files.Length < 1))
            {
                return;
            }

            textEQFolder.Text = Path.GetDirectoryName(_files.GetValue(0).ToString());

            CheckZoneList();

            for (int _filenum = 0; _filenum < _files.Length; _filenum++)
            {
                FileInfo _file = new FileInfo(_files.GetValue(_filenum).ToString());

                if (_file.Exists)
                {
                    //MessageBox.Show(listZoneEffs.Items[0].Name);

                    for (int _zoneindex = 0; _zoneindex < listZoneEffs.Items.Count; _zoneindex++)
                    {
                        if (_file.Name.StartsWith(listZoneEffs.Items[_zoneindex].Text, StringComparison.CurrentCultureIgnoreCase))
                        {
                            listZoneEffs.Items[_zoneindex].Checked = true;
                            listZoneEffs.EnsureVisible(_zoneindex);
                            //listZoneEffs.TopIndex = Math.Max(_zoneindex - 3, 0);
                        }
                    }
                }
            }
        }

        private void buttonBrowseEQFolder_Click(object sender, EventArgs e)
        {
            dialogEQFolder.SelectedPath = textEQFolder.Text;
            
            if (dialogEQFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textEQFolder.Text = dialogEQFolder.SelectedPath;

                CheckZoneList();
            }
        }

        private void SetFormEnabled(bool YesNo)
        {
            textEQFolder.Enabled = YesNo;
            buttonBrowseEQFolder.Enabled = YesNo;
            listZoneEffs.Enabled = YesNo;
            buttonConvert.Text = YesNo ? "Convert!" : "Abort";
        }
        
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            switch (buttonConvert.Text)
            {
                case "Convert!":
                    SetFormEnabled(false);

                    progressConversion.Value = 0;
                    progressConversion.Maximum = listZoneEffs.CheckedItems.Count;

                    List<string> _selectedZones = new List<string>(listZoneEffs.CheckedItems.Count);

                    foreach (ListViewItem _zone in listZoneEffs.CheckedItems)
                    {
                        _selectedZones.Add(_zone.Text);
                    }

                    threadConverter.RunWorkerAsync(_selectedZones);
                    break;
                case "Abort":
                    threadConverter.CancelAsync();
                    break;
            }
        }

        private void listZoneEffs_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            CheckIfReady();
        }

        private void threadConverter_DoWork(object sender, DoWorkEventArgs e)
        {
            
            List<string> _zoneList = e.Argument as List<string>;
            int _zonesConverted = 0;
            e.Result = DialogResult.OK;
            
            foreach (string _zoneNick in _zoneList)
            {
                switch (Eff2EmtConverter.ConvertZone(textEQFolder.Text, _zoneNick))
                {
                    case DialogResult.OK:
                        threadConverter.ReportProgress(++_zonesConverted);
                        break;
                    case DialogResult.Abort:
                        e.Result = DialogResult.Abort;
                        return;
                    case DialogResult.Ignore:
                        break;
                }

                if (threadConverter.CancellationPending)
                {
                    e.Result = DialogResult.Cancel;
                    return;
                }
            }
        }

        private void threadConverter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressConversion.Value = e.ProgressPercentage;

            string _emtFilename = textEQFolder.Text + "\\" + listZoneEffs.CheckedItems[e.ProgressPercentage - 1].Text + ".emt";

            // Don't open every newly merged .emt file if we're batch converting more than 3 files.
            if ((listZoneEffs.CheckedItems.Count < 4) && File.Exists(_emtFilename))
            {
                // Open the file in Notepad++ if available, or Notepad if not. Other text file readers could be added as options here.

                foreach (string _textEditor in TextEditors)
                {
                    if (File.Exists(_textEditor))
                    {
                        System.Diagnostics.Process.Start(_textEditor, _emtFilename);
                        break;
                    }
                }
            }
        }

        private void threadConverter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetFormEnabled(true);

            switch ((DialogResult)e.Result)
            {
                case DialogResult.OK:
                    MessageBox.Show("Conversion process completed.", "Conversion Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DialogResult.Abort:
                    MessageBox.Show("Conversion process aborted.", "Conversion Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Conversion process cancelled.", "Conversion Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void listZoneEffs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialogEff.ShowDialog() == DialogResult.OK)
            {
                // Display the selected file in the textbox and to the user
                MessageBox.Show(openFileDialogEff.FileName);
                fileName = openFileDialogEff.FileName;
                activeEffFile.Text = fileName;
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {

            BinaryReader _effFile = null;
            dataGridView1.Rows.Clear();
            gridRow = 0;

            while (_effFile == null)
            {
                try
                {
                    _effFile = new BinaryReader(File.OpenRead(fileName));
                }
                catch (Exception ex)
                {
                    switch (MessageBox.Show("Could not open Binary File:\n\n" + fileName + "\n\nError Message:\n\n" + ex.Message, "Sound Entry Read Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error))
                    {
                        case System.Windows.Forms.DialogResult.Ignore:
                            return;
                        case System.Windows.Forms.DialogResult.Abort:
                            return;
                    }
                }


                // Read binary entries from *sounds.eff and place numeric values into the datagridview table
                while ((_effFile.BaseStream.Length - _effFile.BaseStream.Position) >= 84)
                {
                    gridRow += 1;
                    EffSoundEntry _effEntry;

                    _effEntry.UnkRef00 = _effFile.ReadInt32();
                    _effEntry.UnkRef04 = _effFile.ReadInt32();
                    _effEntry.Reserved = _effFile.ReadInt32();
                    _effEntry.Sequence = _effFile.ReadInt32();
                    _effEntry.X = _effFile.ReadSingle();
                    _effEntry.Y = _effFile.ReadSingle();
                    _effEntry.Z = _effFile.ReadSingle();
                    _effEntry.Radius = _effFile.ReadSingle();
                    _effEntry.Cooldown1 = _effFile.ReadInt32();
                    _effEntry.Cooldown2 = _effFile.ReadInt32();
                    _effEntry.RandomDelay = _effFile.ReadInt32();
                    _effEntry.Unk44 = _effFile.ReadInt32();
                    _effEntry.SoundID1 = _effFile.ReadInt32();
                    _effEntry.SoundID2 = _effFile.ReadInt32();
                    _effEntry.SoundType = _effFile.ReadByte();
                    _effEntry.UnkPad57 = _effFile.ReadByte();
                    _effEntry.UnkPad58 = _effFile.ReadByte();
                    _effEntry.UnkPad59 = _effFile.ReadByte();
                    _effEntry.AsDistance = _effFile.ReadInt32();
                    _effEntry.UnkRange64 = _effFile.ReadInt32();
                    _effEntry.FadeOutMS = _effFile.ReadInt32();
                    _effEntry.UnkRange72 = _effFile.ReadInt32();
                    _effEntry.FullVolRange = _effFile.ReadInt32();
                    _effEntry.UnkRange80 = _effFile.ReadInt32();
                    dataGridView1.Rows.Add(_effEntry.UnkRef00, _effEntry.UnkRef04, _effEntry.Reserved, _effEntry.Sequence, _effEntry.X, _effEntry.Y, _effEntry.Z, _effEntry.Radius, _effEntry.Cooldown1, _effEntry.Cooldown2, _effEntry.RandomDelay, _effEntry.Unk44, _effEntry.SoundID1, _effEntry.SoundID2, _effEntry.SoundType, _effEntry.UnkPad57, _effEntry.UnkPad58, _effEntry.UnkPad59, _effEntry.AsDistance, _effEntry.UnkRange64, _effEntry.FadeOutMS, _effEntry.UnkRange72, _effEntry.FullVolRange, _effEntry.UnkRange80, gridRow);
                }

            }

            //SoundsEffImport.Import(fileName);
        }
    }
}
