namespace ConsoleColors
{
    /// Container class for all available foreground colors
    public static class Clr
    {
        /// Default foreground ANSI code (format strings with it)
        public const string Default = @"\e[39m";
        /// Black foreground ANSI code (format strings with it)
        public const string Black = @"\e[30m";
        /// White foreground ANSI code (format strings with it)
        public const string White = @"\e[97m";
        /// Red foreground ANSI code (format strings with it)
        public const string Red = @"\e[31m";
        /// Green foreground ANSI code (format strings with it)
        public const string Green = @"\e[32m";
        /// Yellow foreground ANSI code (format strings with it)
        public const string Yellow = @"\e[33m";
        /// Blue foreground ANSI code (format strings with it)
        public const string Blue = @"\e[34m";
        /// Magenta foreground ANSI code (format strings with it)
        public const string Magenta = @"\e[35m";
        /// Cyan foreground ANSI code (format strings with it)
        public const string Cyan = @"\e[36m";
        /// Light gray foreground ANSI code (format strings with it)
        public const string LtGray = @"\e[37m";
        /// Dark gray foreground ANSI code (format strings with it)
        public const string DrkGray = @"\e[90m";
        /// Light red foreground ANSI code (format strings with it)
        public const string LtRed = @"\e[91m";
        /// Light green foreground ANSI code (format strings with it)
        public const string LtGreen = @"\e[92m";
        /// Light yellow foreground ANSI code (format strings with it)
        public const string LtYellow = @"\e[93m";
        /// Light blue foreground ANSI code (format strings with it)
        public const string LtBlue = @"\e[94m";
        /// Light magenta foreground ANSI code (format strings with it)
        public const string LtMagenta = @"\e[95m";
        /// Light cyan foreground ANSI code (format strings with it)
        public const string LtCyan = @"\e[96m";

        /// Set foreground color to default without printing
        public static void SetDefault() => Printer._bash.Echo(Default, "-en");
        /// Set foreground color to black without printing
        public static void SetBlack() => Printer._bash.Echo(Black, "-en");
        /// Set foreground color to white without printing
        public static void SetWhite() => Printer._bash.Echo(White, "-en");
        /// Set foreground color to red without printing
        public static void SetRed() => Printer._bash.Echo(Red, "-en");
        /// Set foreground color to green without printing
        public static void SetGreen() => Printer._bash.Echo(Green, "-en");
        /// Set foreground color to yellow without printing
        public static void SetYellow() => Printer._bash.Echo(Yellow, "-en");
        /// Set foreground color to blue without printing
        public static void SetBlue() => Printer._bash.Echo(Blue, "-en");
        /// Set foreground color to magenta without printing
        public static void SetMagenta() => Printer._bash.Echo(Magenta, "-en");
        /// Set foreground color to cyan without printing
        public static void SetCyan() => Printer._bash.Echo(Cyan, "-en");
        /// Set foreground color to light gray without printing
        public static void SetLtGray() => Printer._bash.Echo(LtGray, "-en");
        /// Set foreground color to dark gray without printing
        public static void SetDrkGray() => Printer._bash.Echo(DrkGray, "-en");
        /// Set foreground color to light red without printing
        public static void SetLtRed() => Printer._bash.Echo(LtRed, "-en");
        /// Set foreground color to light green without printing
        public static void SetLtGreen() => Printer._bash.Echo(LtGreen, "-en");
        /// Set foreground color to light yellow without printing
        public static void SetLtYellow() => Printer._bash.Echo(LtYellow, "-en");
        /// Set foreground color to light blue without printing
        public static void SetLtBlue() => Printer._bash.Echo(LtBlue, "-en");
        /// Set foreground color to light magenta without printing
        public static void SetLtMagenta() => Printer._bash.Echo(LtMagenta, "-en");
        /// Set foreground color to light cyan without printing
        public static void SetLtCyan() => Printer._bash.Echo(LtCyan, "-en");


        /// Returns all available foreground colors as an array
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
