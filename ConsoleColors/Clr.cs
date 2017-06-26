namespace ConsoleColors
{
    public static class Clr
    {
        public static readonly string Default = @"\e[39m";
        public static readonly string Black = @"\e[30m";
        public static readonly string White = @"\e[97m";
        public static readonly string Red = @"\e[31m";
        public static readonly string Green = @"\e[32m";
        public static readonly string Yellow = @"\e[33m";
        public static readonly string Blue = @"\e[34m";
        public static readonly string Magenta = @"\e[35m";
        public static readonly string Cyan = @"\e[36m";
        public static readonly string LtGray = @"\e[37m";
        public static readonly string DrkGray = @"\e[90m";
        public static readonly string LtRed = @"\e[91m";
        public static readonly string LtGreen = @"\e[92m";
        public static readonly string LtYellow = @"\e[93m";
        public static readonly string LtBlue = @"\e[94m";
        public static readonly string LtMagenta = @"\e[95m";
        public static readonly string LtCyan = @"\e[96m";

        public static void SetDefault() => Printer._bash.Echo(Default, "-en");
        public static void SetBlack() => Printer._bash.Echo(Black, "-en");
        public static void SetWhite() => Printer._bash.Echo(White, "-en");
        public static void SetRed() => Printer._bash.Echo(Red, "-en");
        public static void SetGreen() => Printer._bash.Echo(Green, "-en");
        public static void SetYellow() => Printer._bash.Echo(Yellow, "-en");
        public static void SetBlue() => Printer._bash.Echo(Blue, "-en");
        public static void SetMagenta() => Printer._bash.Echo(Magenta, "-en");
        public static void SetCyan() => Printer._bash.Echo(Cyan, "-en");
        public static void SetLtGray() => Printer._bash.Echo(LtGray, "-en");
        public static void SetDrkGray() => Printer._bash.Echo(DrkGray, "-en");
        public static void SetLtRed() => Printer._bash.Echo(LtRed, "-en");
        public static void SetLtGreen() => Printer._bash.Echo(LtGreen, "-en");
        public static void SetLtYellow() => Printer._bash.Echo(LtYellow, "-en");
        public static void SetLtBlue() => Printer._bash.Echo(LtBlue, "-en");
        public static void SetLtMagenta() => Printer._bash.Echo(LtMagenta, "-en");
        public static void SetLtCyan() => Printer._bash.Echo(LtCyan, "-en");
        
        public static string[] ToArray() => new string[]
        {
            Default,
            Black,
            White,
            Red,
            Green,
            Yellow,
            Blue,
            Magenta,
            Cyan,
            LtGray,
            DrkGray,
            LtRed,
            LtGreen,
            LtYellow,
            LtBlue,
            LtMagenta,
            LtCyan,
        };
    }
}
