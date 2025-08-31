namespace SMBW_SaveGame_Editor.Data
{
    public static class Byte_Patterns
    {
        //Game Progression
        public static byte[] COMPLETE_GAME                  = new byte[] { 0xB4, 0xC9, 0x3E, 0x5D}; // Medal on Intro Screen
        public static byte[] INTRO_CUTSCENE_COMPLETED       = new byte[] { 0x52, 0xCC, 0xF1, 0x89 }; // Has the intro been played
        public static byte[] GRAND_SEED_WORLD1              = new byte[] { 0x59, 0x58, 0x81, 0x55 }; // Seed for World 1
        public static byte[] GRAND_SEED_WORLD2              = new byte[] { 0x86, 0xBA, 0xAB, 0x49 }; // Seed for World 2
        public static byte[] GRAND_SEED_WORLD3              = new byte[] { 0xD6, 0xD8, 0x50, 0xB5 }; // Seed for World 3
        public static byte[] GRAND_SEED_WORLD4              = new byte[] { 0x6E, 0x7F, 0xCF, 0x1D}; // Seed for World 4
        public static byte[] GRAND_SEED_WORLD5              = new byte[] { 0x00, 0x3E, 0x5A, 0x0D}; // Seed for World 5
        public static byte[] GRAND_SEED_WORLD6              = new byte[] { 0x2B, 0x0D, 0x66, 0xD4}; // Seed for World 6
        public static byte[] COINS_PATTERN                  =  new byte[] { 0x21, 0xBB, 0xF0, 0x17 }; // Coins
        public static byte[] PURPLE_COINS_PATTERN           =  new byte[] { 0x27, 0x68, 0xEE, 0xF4 }; // Purple Coins

    }
}
