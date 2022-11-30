using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Eff2EmtGUI
{
    class SoundsEffExport
    {

        protected static Dictionary<int, string> HardCodedSoundFiles = new Dictionary<int, string>()
        {
            {  39, "death_me" },
            { 143, "thunder1" },
            { 144, "thunder2" },
            { 158, "wind_lp1" },
            { 159, "rainloop" },
            { 160, "torch_lp" },
            { 161, "watundlp" }
        };

        protected static Dictionary<int, string> DefaultMusicFiles = new Dictionary<int, string>()
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

        protected struct EffSoundEntry
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


    }
}
