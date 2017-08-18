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
        public static void SetDefault() => Printer.Echo(Default, "-e");
        /// Set foreground color to black without printing
        public static void SetBlack() => Printer.Echo(Black, "-e");
        /// Set foreground color to white without printing
        public static void SetWhite() => Printer.Echo(White, "-e");
        /// Set foreground color to red without printing
        public static void SetRed() => Printer.Echo(Red, "-e");
        /// Set foreground color to green without printing
        public static void SetGreen() => Printer.Echo(Green, "-e");
        /// Set foreground color to yellow without printing
        public static void SetYellow() => Printer.Echo(Yellow, "-e");
        /// Set foreground color to blue without printing
        public static void SetBlue() => Printer.Echo(Blue, "-e");
        /// Set foreground color to magenta without printing
        public static void SetMagenta() => Printer.Echo(Magenta, "-e");
        /// Set foreground color to cyan without printing
        public static void SetCyan() => Printer.Echo(Cyan, "-e");
        /// Set foreground color to light gray without printing
        public static void SetLtGray() => Printer.Echo(LtGray, "-e");
        /// Set foreground color to dark gray without printing
        public static void SetDrkGray() => Printer.Echo(DrkGray, "-e");
        /// Set foreground color to light red without printing
        public static void SetLtRed() => Printer.Echo(LtRed, "-e");
        /// Set foreground color to light green without printing
        public static void SetLtGreen() => Printer.Echo(LtGreen, "-e");
        /// Set foreground color to light yellow without printing
        public static void SetLtYellow() => Printer.Echo(LtYellow, "-e");
        /// Set foreground color to light blue without printing
        public static void SetLtBlue() => Printer.Echo(LtBlue, "-e");
        /// Set foreground color to light magenta without printing
        public static void SetLtMagenta() => Printer.Echo(LtMagenta, "-e");
        /// Set foreground color to light cyan without printing
        public static void SetLtCyan() => Printer.Echo(LtCyan, "-e");


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
