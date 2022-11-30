namespace Eff2EmtGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textEQFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowseEQFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelZonesSelected = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelZoneCount = new System.Windows.Forms.Label();
            this.dialogEQFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.listZoneEffs = new System.Windows.Forms.ListView();
            this.progressConversion = new System.Windows.Forms.ProgressBar();
            this.threadConverter = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.activeEffFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialogEff = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UnkRef00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnkRef04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cooldown1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cooldown2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unk44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoundID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoundID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoundType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnkPad57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnkPad58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnkPad59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnkRange64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FadeOutMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnkRange72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullVolRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnkRange80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "&EverQuest Folder Location:";
            // 
            // textEQFolder
            // 
            this.textEQFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEQFolder.Location = new System.Drawing.Point(26, 58);
            this.textEQFolder.Margin = new System.Windows.Forms.Padding(7);
            this.textEQFolder.Name = "textEQFolder";
            this.textEQFolder.Size = new System.Drawing.Size(1110, 35);
            this.textEQFolder.TabIndex = 1;
            this.textEQFolder.TextChanged += new System.EventHandler(this.textEQFolder_TextChanged);
            // 
            // buttonBrowseEQFolder
            // 
            this.buttonBrowseEQFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseEQFolder.Location = new System.Drawing.Point(1141, 58);
            this.buttonBrowseEQFolder.Margin = new System.Windows.Forms.Padding(7);
            this.buttonBrowseEQFolder.Name = "buttonBrowseEQFolder";
            this.buttonBrowseEQFolder.Size = new System.Drawing.Size(86, 45);
            this.buttonBrowseEQFolder.TabIndex = 2;
            this.buttonBrowseEQFolder.Text = "&...";
            this.buttonBrowseEQFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseEQFolder.Click += new System.EventHandler(this.buttonBrowseEQFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Zones selected:";
            // 
            // labelZonesSelected
            // 
            this.labelZonesSelected.Location = new System.Drawing.Point(236, 145);
            this.labelZonesSelected.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelZonesSelected.Name = "labelZonesSelected";
            this.labelZonesSelected.Size = new System.Drawing.Size(58, 31);
            this.labelZonesSelected.TabIndex = 6;
            this.labelZonesSelected.Text = "0";
            this.labelZonesSelected.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(26, 459);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(7);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(224, 62);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert!";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            // 
            // labelZoneCount
            // 
            this.labelZoneCount.Location = new System.Drawing.Point(308, 145);
            this.labelZoneCount.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelZoneCount.Name = "labelZoneCount";
            this.labelZoneCount.Size = new System.Drawing.Size(72, 31);
            this.labelZoneCount.TabIndex = 8;
            this.labelZoneCount.Text = "0";
            // 
            // listZoneEffs
            // 
            this.listZoneEffs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listZoneEffs.CheckBoxes = true;
            this.listZoneEffs.HideSelection = false;
            this.listZoneEffs.Location = new System.Drawing.Point(26, 183);
            this.listZoneEffs.Margin = new System.Windows.Forms.Padding(7);
            this.listZoneEffs.Name = "listZoneEffs";
            this.listZoneEffs.Size = new System.Drawing.Size(1196, 267);
            this.listZoneEffs.TabIndex = 4;
            this.listZoneEffs.UseCompatibleStateImageBehavior = false;
            this.listZoneEffs.View = System.Windows.Forms.View.List;
            this.listZoneEffs.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listZoneEffs_ItemChecked);
            this.listZoneEffs.SelectedIndexChanged += new System.EventHandler(this.listZoneEffs_SelectedIndexChanged);
            // 
            // progressConversion
            // 
            this.progressConversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressConversion.Location = new System.Drawing.Point(256, 459);
            this.progressConversion.Margin = new System.Windows.Forms.Padding(7);
            this.progressConversion.Name = "progressConversion";
            this.progressConversion.Size = new System.Drawing.Size(966, 62);
            this.progressConversion.TabIndex = 9;
            // 
            // threadConverter
            // 
            this.threadConverter.WorkerReportsProgress = true;
            this.threadConverter.WorkerSupportsCancellation = true;
            this.threadConverter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadConverter_DoWork);
            this.threadConverter.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.threadConverter_ProgressChanged);
            this.threadConverter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadConverter_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(721, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "zone_sounds.eff Sound Emitter Direct Binary Editor (Experimental)";
            // 
            // activeEffFile
            // 
            this.activeEffFile.Location = new System.Drawing.Point(26, 560);
            this.activeEffFile.Name = "activeEffFile";
            this.activeEffFile.Size = new System.Drawing.Size(696, 35);
            this.activeEffFile.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(728, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Select *sounds.eff file for Direct Editing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogEff
            // 
            this.openFileDialogEff.FileName = "openFileDialogEff";
            this.openFileDialogEff.Filter = "Sound Emitters (*sounds.eff) | *sounds.eff";
            this.openFileDialogEff.InitialDirectory = "textEQFolder.Text";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnkRef00,
            this.UnkRef04,
            this.Reserved,
            this.Sequence,
            this.X,
            this.Y,
            this.Z,
            this.Radius,
            this.Cooldown1,
            this.Cooldown2,
            this.RandomDelay,
            this.Unk44,
            this.SoundID1,
            this.SoundID2,
            this.SoundType,
            this.UnkPad57,
            this.UnkPad58,
            this.UnkPad59,
            this.AsDistance,
            this.UnkRange64,
            this.FadeOutMS,
            this.UnkRange72,
            this.FullVolRange,
            this.UnkRange80});
            this.dataGridView1.Location = new System.Drawing.Point(26, 611);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(4000, 250);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1196, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1196, 250);
            this.dataGridView1.TabIndex = 13;
            // 
            // UnkRef00
            // 
            this.UnkRef00.HeaderText = "UnkRef00";
            this.UnkRef00.MinimumWidth = 40;
            this.UnkRef00.Name = "UnkRef00";
            this.UnkRef00.Width = 150;
            // 
            // UnkRef04
            // 
            this.UnkRef04.HeaderText = "UnkRef04";
            this.UnkRef04.MinimumWidth = 40;
            this.UnkRef04.Name = "UnkRef04";
            this.UnkRef04.Width = 150;
            // 
            // Reserved
            // 
            this.Reserved.HeaderText = "Reserved";
            this.Reserved.MinimumWidth = 40;
            this.Reserved.Name = "Reserved";
            this.Reserved.Width = 150;
            // 
            // Sequence
            // 
            this.Sequence.HeaderText = "Sequence";
            this.Sequence.MinimumWidth = 40;
            this.Sequence.Name = "Sequence";
            this.Sequence.Width = 150;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 40;
            this.X.Name = "X";
            this.X.Width = 150;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 40;
            this.Y.Name = "Y";
            this.Y.Width = 150;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.MinimumWidth = 40;
            this.Z.Name = "Z";
            this.Z.Width = 150;
            // 
            // Radius
            // 
            this.Radius.HeaderText = "Radius";
            this.Radius.MinimumWidth = 40;
            this.Radius.Name = "Radius";
            this.Radius.Width = 150;
            // 
            // Cooldown1
            // 
            this.Cooldown1.HeaderText = "Cooldown1";
            this.Cooldown1.MinimumWidth = 40;
            this.Cooldown1.Name = "Cooldown1";
            this.Cooldown1.Width = 150;
            // 
            // Cooldown2
            // 
            this.Cooldown2.HeaderText = "Cooldown2";
            this.Cooldown2.MinimumWidth = 40;
            this.Cooldown2.Name = "Cooldown2";
            this.Cooldown2.Width = 150;
            // 
            // RandomDelay
            // 
            this.RandomDelay.HeaderText = "RandomDelay";
            this.RandomDelay.MinimumWidth = 40;
            this.RandomDelay.Name = "RandomDelay";
            this.RandomDelay.Width = 150;
            // 
            // Unk44
            // 
            this.Unk44.HeaderText = "Unk44";
            this.Unk44.MinimumWidth = 40;
            this.Unk44.Name = "Unk44";
            this.Unk44.Width = 150;
            // 
            // SoundID1
            // 
            this.SoundID1.HeaderText = "SoundID1";
            this.SoundID1.MinimumWidth = 40;
            this.SoundID1.Name = "SoundID1";
            this.SoundID1.Width = 150;
            // 
            // SoundID2
            // 
            this.SoundID2.HeaderText = "SoundID2";
            this.SoundID2.MinimumWidth = 40;
            this.SoundID2.Name = "SoundID2";
            this.SoundID2.Width = 150;
            // 
            // SoundType
            // 
            this.SoundType.HeaderText = "SoundType";
            this.SoundType.MinimumWidth = 40;
            this.SoundType.Name = "SoundType";
            this.SoundType.Width = 150;
            // 
            // UnkPad57
            // 
            this.UnkPad57.HeaderText = "UnkPad57";
            this.UnkPad57.MinimumWidth = 40;
            this.UnkPad57.Name = "UnkPad57";
            this.UnkPad57.Width = 150;
            // 
            // UnkPad58
            // 
            this.UnkPad58.HeaderText = "UnkPad58";
            this.UnkPad58.MinimumWidth = 40;
            this.UnkPad58.Name = "UnkPad58";
            this.UnkPad58.Width = 150;
            // 
            // UnkPad59
            // 
            this.UnkPad59.HeaderText = "UnkPad59";
            this.UnkPad59.MinimumWidth = 40;
            this.UnkPad59.Name = "UnkPad59";
            this.UnkPad59.Width = 150;
            // 
            // AsDistance
            // 
            this.AsDistance.HeaderText = "AsDistance";
            this.AsDistance.MinimumWidth = 40;
            this.AsDistance.Name = "AsDistance";
            this.AsDistance.Width = 150;
            // 
            // UnkRange64
            // 
            this.UnkRange64.HeaderText = "UnkRange64";
            this.UnkRange64.MinimumWidth = 40;
            this.UnkRange64.Name = "UnkRange64";
            this.UnkRange64.Width = 150;
            // 
            // FadeOutMS
            // 
            this.FadeOutMS.HeaderText = "FadeOutMS";
            this.FadeOutMS.MinimumWidth = 40;
            this.FadeOutMS.Name = "FadeOutMS";
            this.FadeOutMS.Width = 150;
            // 
            // UnkRange72
            // 
            this.UnkRange72.HeaderText = "UnkRange72";
            this.UnkRange72.MinimumWidth = 40;
            this.UnkRange72.Name = "UnkRange72";
            this.UnkRange72.Width = 150;
            // 
            // FullVolRange
            // 
            this.FullVolRange.HeaderText = "FullVolRange";
            this.FullVolRange.MinimumWidth = 40;
            this.FullVolRange.Name = "FullVolRange";
            this.FullVolRange.Width = 150;
            // 
            // UnkRange80
            // 
            this.UnkRange80.HeaderText = "UnkRange80";
            this.UnkRange80.MinimumWidth = 40;
            this.UnkRange80.Name = "UnkRange80";
            this.UnkRange80.Width = 150;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(26, 882);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(580, 70);
            this.Import.TabIndex = 14;
            this.Import.Text = "Import Values (Will revert unsaved changes)";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Export.Location = new System.Drawing.Point(612, 882);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(609, 70);
            this.Export.TabIndex = 15;
            this.Export.Text = "Export Values (Will save changes)";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 1412);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activeEffFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressConversion);
            this.Controls.Add(this.listZoneEffs);
            this.Controls.Add(this.labelZoneCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelZonesSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowseEQFolder);
            this.Controls.Add(this.textEQFolder);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimumSize = new System.Drawing.Size(1281, 438);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEQFolder;
        private System.Windows.Forms.Button buttonBrowseEQFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelZonesSelected;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelZoneCount;
        private System.Windows.Forms.FolderBrowserDialog dialogEQFolder;
        private System.Windows.Forms.ListView listZoneEffs;
        private System.Windows.Forms.ProgressBar progressConversion;
        private System.ComponentModel.BackgroundWorker threadConverter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox activeEffFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogEff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnkRef00;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnkRef04;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radius;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cooldown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cooldown2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unk44;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoundID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoundID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoundType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnkPad57;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnkPad58;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnkPad59;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnkRange64;
        private System.Windows.Forms.DataGridViewTextBoxColumn FadeOutMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnkRange72;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullVolRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnkRange80;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Export;
    }
}

