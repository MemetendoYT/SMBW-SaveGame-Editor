using System.Collections.Generic;
using System.IO;

namespace SMBW_SaveGame_Editor.Data
{
    public class LevelInfo
    {
        public string Name { get; set; }
        public uint CourseClearHex { get; set; }
        public uint GoalWonderSeed { get; set; }

    }

    public static class GameData
    {

        public static List<LevelInfo> Course_001 = new List<LevelInfo>()
{
    new LevelInfo {
        Name = "Welcome to the Flower Kingdom!",
        CourseClearHex = 0x43F0,
        GoalWonderSeed = 0x3348
    }
};

        public static List<LevelInfo> Course_002 = new List<LevelInfo>()
{
    new LevelInfo {
        Name = "Piranha Plants on Parade",
        CourseClearHex = 0x43F4,
        GoalWonderSeed = 0x334C,
    }
};

        public static List<LevelInfo> Course_003 = new List<LevelInfo>()
{
    new LevelInfo {
        Name = "Here Come the Hoppos",
        CourseClearHex = 0x4400,
        GoalWonderSeed = 0x3358,
    }
};

        public static List<LevelInfo> Course_004 = new List<LevelInfo>()
{
    new LevelInfo {
        Name = "Scram, Skedaddlers!",
        CourseClearHex = 0x43F8,
        GoalWonderSeed = 0x3350,
    }
};

        public static List<LevelInfo> Course_005 = new List<LevelInfo>()
{
    new LevelInfo {
        Name = "Bulrush Coming Through!",
        CourseClearHex = 0x3,
        GoalWonderSeed = 0x4,
    }
};

        public static Dictionary<string, List<LevelInfo>> AllCourses = new Dictionary<string, List<LevelInfo>>()
{
    { "Course_001", Course_001 },
    { "Course_002", Course_002 },
    { "Course_003", Course_003 },
    {  "Course_004", Course_004 },
};

    }
}
