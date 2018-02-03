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
        public static void SetDefault() => Printer.Printf(Default, newLine: false);
        /// Set foreground color to black without printing
        public static void SetBlack() => Printer.Printf(Black, newLine: false);
        /// Set foreground color to white without printing
        public static void SetWhite() => Printer.Printf(White, newLine: false);
        /// Set foreground color to red without printing
        public static void SetRed() => Printer.Printf(Red, newLine: false);
        /// Set foreground color to green without printing
        public static void SetGreen() => Printer.Printf(Green, newLine: false);
        /// Set foreground color to yellow without printing
        public static void SetYellow() => Printer.Printf(Yellow, newLine: false);
        /// Set foreground color to blue without printing
        public static void SetBlue() => Printer.Printf(Blue, newLine: false);
        /// Set foreground color to magenta without printing
        public static void SetMagenta() => Printer.Printf(Magenta, newLine: false);
        /// Set foreground color to cyan without printing
        public static void SetCyan() => Printer.Printf(Cyan, newLine: false);
        /// Set foreground color to light gray without printing
        public static void SetLtGray() => Printer.Printf(LtGray, newLine: false);
        /// Set foreground color to dark gray without printing
        public static void SetDrkGray() => Printer.Printf(DrkGray, newLine: false);
        /// Set foreground color to light red without printing
        public static void SetLtRed() => Printer.Printf(LtRed, newLine: false);
        /// Set foreground color to light green without printing
        public static void SetLtGreen() => Printer.Printf(LtGreen, newLine: false);
        /// Set foreground color to light yellow without printing
        public static void SetLtYellow() => Printer.Printf(LtYellow, newLine: false);
        /// Set foreground color to light blue without printing
        public static void SetLtBlue() => Printer.Printf(LtBlue, newLine: false);
        /// Set foreground color to light magenta without printing
        public static void SetLtMagenta() => Printer.Printf(LtMagenta, newLine: false);
        /// Set foreground color to light cyan without printing
        public static void SetLtCyan() => Printer.Printf(LtCyan, newLine: false);


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
