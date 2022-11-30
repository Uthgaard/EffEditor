using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Eff2EmtGUI
{
    class SoundsEffImport
    {

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

        public static DialogResult Import(string fileName)
        {
            if (fileName == null)
            {
                return DialogResult.Abort;
            }

            // code goes here

            // Open ZoneNick_sounds.eff (Required)

            BinaryReader _effFile = null;

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
                            return DialogResult.Ignore;
                        case System.Windows.Forms.DialogResult.Abort:
                            return DialogResult.Abort;
                    }
                }


                // Read binary entries from *sounds.eff and place numeric values into the datagridview table
                while ((_effFile.BaseStream.Length - _effFile.BaseStream.Position) >= 84)
                {
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
                    //dataGridView1.Rows.Add(_effEntry.UnkRef00, _effEntry.UnkRef04, _effEntry.Reserved, _effEntry.Sequence, _effEntry.X, _effEntry.Y, _effEntry.Z, _effEntry.Radius, _effEntry.Cooldown1, _effEntry.Cooldown2, _effEntry.RandomDelay, _effEntry.Unk44, _effEntry.SoundID1, _effEntry.SoundID2, _effEntry.SoundType, _effEntry.UnkPad57, _effEntry.UnkPad58, _effEntry.UnkPad59, _effEntry.AsDistance, _effEntry.UnkRange64, _effEntry.FadeOutMS, _effEntry.UnkRange72, _effEntry.FullVolRange, _effEntry.UnkRange80);
                }

            }

            return System.Windows.Forms.DialogResult.OK;

        }

    }

}