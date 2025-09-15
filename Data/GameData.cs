using System.Collections.Generic;


public class LevelInfo
{
    public string Name { get; set; }
    public int CourseClearHex { get; set; }
    public int GoalWonderSeed { get; set; }
    public int WonderSeed { get; set; }
    public int PurpleCoin1 { get; set; }
    public int PurpleCoin2 { get; set; }
    public int PurpleCoin3 { get; set; }
    public int ClapperGate { get; set; }

    public int PurpleCoinOffset { get; set; }
    public int ClapperGateOrgVal { get; set; }
}

public static class CourseData
{
    public static Dictionary<string, LevelInfo> World1Courses = new Dictionary<string, LevelInfo>
    {
        ["COURSE_001"] = new LevelInfo
        {
            Name = "Welcome to the Flower Kingdom!",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0, 
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1,
        },
        ["COURSE_002"] = new LevelInfo
        {
            Name = "Piranha Plants on Parade",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1,
        },
        ["COURSE_004"] = new LevelInfo
        {
            Name = "Scram, Skedaddlers!",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1,
        },
        ["COURSE_005"] = new LevelInfo
        {
            Name = "Bulrush Coming Through!",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_003"] = new LevelInfo
        {
            Name = "Here Come the Hoppos",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_200"] = new LevelInfo
        {
            Name = "Wiggler Race Mountaineering!",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = -1,
            PurpleCoinOffset = -1,
            ClapperGate = -1,
        },
        ["COURSE_013"] = new LevelInfo
        {
            Name = "Rolla Koopa Derby",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1,
        },
        ["COURSE_007"] = new LevelInfo
        {
            Name = "Swamp Pipe Crawl",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_008"] = new LevelInfo
        {
            Name = "Angry Spikes and Sinkin' Pipes",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_009"] = new LevelInfo
        {
            Name = "Bulrush Express",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_006"] = new LevelInfo
        {
            Name = "Sproings in the Twilight Forest",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_010"] = new LevelInfo
        {
            Name = "Cosmic Hoppos",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_418"] = new LevelInfo
        {
            Name = "Badge Challenge Parachute Cap I",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = -1,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_411"] = new LevelInfo
        {
            Name = "Badge Challenge Wall-Climb Jump I",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = -1,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_400"] = new LevelInfo
        {
            Name = "Expert Badge Challenge Jet Run I",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = -1,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        },
        ["COURSE_401"] = new LevelInfo
        {
            Name = "Break Time! Hurry, Hurry",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = -1,
            PurpleCoinOffset = -1,
            ClapperGate = -1
        },
        ["COURSE_402"] = new LevelInfo
        {
            Name = "Break Time! Wonder Token Tunes",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = -1,
            PurpleCoinOffset = -1,
            ClapperGate = -1
        },
        ["COURSE_403"] = new LevelInfo
        {
            Name = "Break Time! Pop Up, Hoppo!",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = -1,
            PurpleCoinOffset = -1,
            ClapperGate = -1
        },
        ["COURSE_150"] = new LevelInfo
        {
            Name = "Pipe-Rock Plateau Palace",
            CourseClearHex = 0,
            GoalWonderSeed = -1,
            WonderSeed = 0,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = 0,
            ClapperGateOrgVal = 64,
        },
        ["COURSE_250"] = new LevelInfo
        {
            Name = "KO Arena Pipe-Rock Rumble",
            CourseClearHex = 0,
            GoalWonderSeed = 0,
            WonderSeed = -1,
            PurpleCoinOffset = 0,
            PurpleCoin1 = 0,
            PurpleCoin2 = 0,
            PurpleCoin3 = 0,
            ClapperGate = -1
        }
    };
}