using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SMBW_SaveGame_Editor.Data;

namespace SMBW_SaveGame_Editor.SaveFile
{
    public class SMBW_SaveFile : SaveFile
    {
        #region Offsets
        public int COMPLETE_GAME;
        public int WORLD1_SEED;
        public int WORLD2_SEED;
        public int WORLD3_SEED;
        public int WORLD4_SEED;
        public int WORLD5_SEED;
        public int WORLD6_SEED;
        public int Coins;
        public int COINS_VALUE;
        public int P_Coins;
        public int PURPLE_COINS;
        public int Lives;
        public int COURSE_001;
        public int COURSE_001_END_SEED;
        public int COURSE_002;
        public int COURSE_002_END_SEED;
        public int COURSE_003;
        public int COURSE_003_END_SEED;
        public int COURSE_004;
        public int COURSE_004_END_SEED;
        public int COURSE_005;
        public int COURSE_005_END_SEED;
        public int COURSE_006;
        public int COURSE_006_END_SEED;
        public int[] Courses;
         public int[] EndSeed;
        #endregion
        public SMBW_SaveFile(string path)
        {
            if (!File.Exists(path)) return;

            _Path = path;
            _Data = File.ReadAllBytes(_Path);
            IsLoaded = true;

            Courses = new int[] { COURSE_001, COURSE_002, COURSE_003, COURSE_004};
            EndSeed = new int[] { COURSE_001_END_SEED, COURSE_002_END_SEED, COURSE_003_END_SEED, COURSE_004_END_SEED};
            CreateBackup();
            LoadOffsets();
            Coins = ReadCoins();
            P_Coins = ReadPCoins();
            Lives = ReadLives();
     
        }

        private void LoadOffsets()
        {
           
            COMPLETE_GAME = FindBytePatternOffset(Byte_Patterns.COMPLETE_GAME);
            WORLD1_SEED = FindBytePatternOffset(Byte_Patterns.GRAND_SEED_WORLD1);
            WORLD2_SEED = FindBytePatternOffset(Byte_Patterns.GRAND_SEED_WORLD2);
            WORLD3_SEED = FindBytePatternOffset(Byte_Patterns.GRAND_SEED_WORLD3);
            WORLD4_SEED = FindBytePatternOffset(Byte_Patterns.GRAND_SEED_WORLD4);
            WORLD5_SEED = FindBytePatternOffset(Byte_Patterns.GRAND_SEED_WORLD5);
            WORLD6_SEED = FindBytePatternOffset(Byte_Patterns.GRAND_SEED_WORLD6);
            COINS_VALUE = FindBytePatternOffset(Byte_Patterns.COINS_PATTERN);
            PURPLE_COINS = FindBytePatternOffset(Byte_Patterns.PURPLE_COINS_PATTERN);



            int count = Data.GameData.AllCourses.Values.Sum(c => c.Count);
            int i = 0;
            foreach (var course in Data.GameData.AllCourses.Values)
            {
                foreach (var level in course)
                {
                    uint Hex = level.CourseClearHex;
                    uint GoalSeed = level.GoalWonderSeed;
                    Courses[i] = (int)Hex;
                    EndSeed[i] = (int)GoalSeed;
                    i++;
                }
 
            }

        }


        public void PatchSaveFile()
        {
            WriteCoins(Coins);
            WritePCoins(P_Coins);
            WriteLives(Lives);
            WriteSaveFile();
        }

        public int ReadLives()
        {
            return _Data[0x167C];

        }

        public int ReadCourseComplete(String Hex)
        {
            return _Data[0x167C];

        }

        public void WriteLives(int value)
        {
            _Data[0x167C] = (byte)value;

        }
        public int ReadCoins()
        {
            return _Data[COINS_VALUE];
        }
        public void WriteCoins(int value)
        {
            _Data[COINS_VALUE] = (byte)value;

        }

        public int ReadPCoins()
        {
           return _Data[PURPLE_COINS] | (_Data[PURPLE_COINS + 1] << 8);
        }
        public void WritePCoins(int value)
        {
            byte lowByte = (byte)(value & 0xFF);         
            byte highByte = (byte)((value >> 8) & 0xFF);
            _Data[PURPLE_COINS] = lowByte;
            _Data[PURPLE_COINS + 1] = highByte;

        }
    }
}
