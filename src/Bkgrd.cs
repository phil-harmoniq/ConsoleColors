namespace ConsoleColors
{
    /// Container class for all available foreground colors
    public class Bkgrd
    {
        /// Default background ANSI code (format strings with it)
        public static readonly string Default = @"\e[49m";
        /// Black background ANSI code (format strings with it)
        public static readonly string Black = @"\e[40m";
        /// White background ANSI code (format strings with it)
        public static readonly string White = @"\e[107m";
        /// Red background ANSI code (format strings with it)
        public static readonly string Red = @"\e[41m";
        /// Green background ANSI code (format strings with it)
        public static readonly string Green = @"\e[42m";
        /// Yellow background ANSI code (format strings with it)
        public static readonly string Yellow = @"\e[43m";
        /// Blue background ANSI code (format strings with it)
        public static readonly string Blue = @"\e[44m";
        /// Magenta background ANSI code (format strings with it)
        public static readonly string Magenta = @"\e[45m";
        /// Cyan background ANSI code (format strings with it)
        public static readonly string Cyan = @"\e[46m";
        /// Light gray background ANSI code (format strings with it)
        public static readonly string LtGray = @"\e[47m";
        /// Dark gray background ANSI code (format strings with it)
        public static readonly string DrkGray = @"\e[100m";
        /// Light red background ANSI code (format strings with it)
        public static readonly string LtRed = @"\e[91m";
        /// Light green background ANSI code (format strings with it)
        public static readonly string LtGreen = @"\e[102m";
        /// Light yellow background ANSI code (format strings with it)
        public static readonly string LtYellow = @"\e[103m";
        /// Light blue background ANSI code (format strings with it)
        public static readonly string LtBlue = @"\e[104m";
        /// Light magenta background ANSI code (format strings with it)
        public static readonly string LtMagenta = @"\e[105m";
        /// Light cyan background ANSI code (format strings with it)
        public static readonly string LtCyan = @"\e[106m";

        /// Set background color to default without printing
        public static void SetDefault() => Printer._bash.Echo(Default, "-en");
        /// Set background color to black without printing
        public static void SetBlack() => Printer._bash.Echo(Black, "-en");
        /// Set background color to white without printing
        public static void SetWhite() => Printer._bash.Echo(White, "-en");
        /// Set background color to red without printing
        public static void SetRed() => Printer._bash.Echo(Red, "-en");
        /// Set background color to green without printing
        public static void SetGreen() => Printer._bash.Echo(Green, "-en");
        /// Set background color to yellow without printing
        public static void SetYellow() => Printer._bash.Echo(Yellow, "-en");
        /// Set background color to blue without printing
        public static void SetBlue() => Printer._bash.Echo(Blue, "-en");
        /// Set background color to magenta without printing
        public static void SetMagenta() => Printer._bash.Echo(Magenta, "-en");
        /// Set background color to cyan without printing
        public static void SetCyan() => Printer._bash.Echo(Cyan, "-en");
        /// Set background color to light gray without printing
        public static void SetLtGray() => Printer._bash.Echo(LtGray, "-en");
        /// Set background color to dark gray without printing
        public static void SetDrkGray() => Printer._bash.Echo(DrkGray, "-en");
        /// Set background color to light red without printing
        public static void SetLtRed() => Printer._bash.Echo(LtRed, "-en");
        /// Set background color to light green without printing
        public static void SetLtGreen() => Printer._bash.Echo(LtGreen, "-en");
        /// Set background color to light yellow without printing
        public static void SetLtYellow() => Printer._bash.Echo(LtYellow, "-en");
        /// Set background color to light blue without printing
        public static void SetLtBlue() => Printer._bash.Echo(LtBlue, "-en");
        /// Set background color to light magenta without printing
        public static void SetLtMagenta() => Printer._bash.Echo(LtMagenta, "-en");
        
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