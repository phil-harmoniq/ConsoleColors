namespace ConsoleColors
{
    /// Container class for all available background colors
    public class Bkgrd
    {
        /// Default background ANSI code (format strings with it)
        public const string Default = @"\e[49m";
        /// Black background ANSI code (format strings with it)
        public const string Black = @"\e[40m";
        /// White background ANSI code (format strings with it)
        public const string White = @"\e[107m";
        /// Red background ANSI code (format strings with it)
        public const string Red = @"\e[41m";
        /// Green background ANSI code (format strings with it)
        public const string Green = @"\e[42m";
        /// Yellow background ANSI code (format strings with it)
        public const string Yellow = @"\e[43m";
        /// Blue background ANSI code (format strings with it)
        public const string Blue = @"\e[44m";
        /// Magenta background ANSI code (format strings with it)
        public const string Magenta = @"\e[45m";
        /// Cyan background ANSI code (format strings with it)
        public const string Cyan = @"\e[46m";
        /// Light gray background ANSI code (format strings with it)
        public const string LtGray = @"\e[47m";
        /// Dark gray background ANSI code (format strings with it)
        public const string DrkGray = @"\e[100m";
        /// Light red background ANSI code (format strings with it)
        public const string LtRed = @"\e[91m";
        /// Light green background ANSI code (format strings with it)
        public const string LtGreen = @"\e[102m";
        /// Light yellow background ANSI code (format strings with it)
        public const string LtYellow = @"\e[103m";
        /// Light blue background ANSI code (format strings with it)
        public const string LtBlue = @"\e[104m";
        /// Light magenta background ANSI code (format strings with it)
        public const string LtMagenta = @"\e[105m";
        /// Light cyan background ANSI code (format strings with it)
        public const string LtCyan = @"\e[106m";

        /// Set background color to default without printing
        public static void SetDefault() => Printer.Printf(Default, newLine: false);
        /// Set background color to black without printing
        public static void SetBlack() => Printer.Printf(Black, newLine: false);
        /// Set background color to white without printing
        public static void SetWhite() => Printer.Printf(White, newLine: false);
        /// Set background color to red without printing
        public static void SetRed() => Printer.Printf(Red, newLine: false);
        /// Set background color to green without printing
        public static void SetGreen() => Printer.Printf(Green, newLine: false);
        /// Set background color to yellow without printing
        public static void SetYellow() => Printer.Printf(Yellow, newLine: false);
        /// Set background color to blue without printing
        public static void SetBlue() => Printer.Printf(Blue, newLine: false);
        /// Set background color to magenta without printing
        public static void SetMagenta() => Printer.Printf(Magenta, newLine: false);
        /// Set background color to cyan without printing
        public static void SetCyan() => Printer.Printf(Cyan, newLine: false);
        /// Set background color to light gray without printing
        public static void SetLtGray() => Printer.Printf(LtGray, newLine: false);
        /// Set background color to dark gray without printing
        public static void SetDrkGray() => Printer.Printf(DrkGray, newLine: false);
        /// Set background color to light red without printing
        public static void SetLtRed() => Printer.Printf(LtRed, newLine: false);
        /// Set background color to light green without printing
        public static void SetLtGreen() => Printer.Printf(LtGreen, newLine: false);
        /// Set background color to light yellow without printing
        public static void SetLtYellow() => Printer.Printf(LtYellow, newLine: false);
        /// Set background color to light blue without printing
        public static void SetLtBlue() => Printer.Printf(LtBlue, newLine: false);
        /// Set background color to light magenta without printing
        public static void SetLtMagenta() => Printer.Printf(LtMagenta, newLine: false);
        
        /// Returns all available background colors as an array
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