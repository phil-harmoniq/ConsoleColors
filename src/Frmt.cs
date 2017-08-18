namespace ConsoleColors
{
    /// Container class for all available formatting options
    public static class Frmt
    {
        /// Bold ANSI code (format strings with it)
        public const string Bold = @"\e[1m";
        /// Dim ANSI code (format strings with it)
        public const string Dim = @"\e[2m";
        /// Underline ANSI code (format strings with it)
        public const string Underline = @"\e[4m";
        /// Invert ANSI code (format strings with it)
        public const string Invert = @"\e[7m";
        /// Hidden ANSI code (format strings with it)
        public const string Hidden = @"\e[8m";

        /// Reset bold ANSI code (format strings with it)
        public const string UnBold = @"\e[21m";
        /// Reset dim ANSI code (format strings with it)
        public const string UnDim = @"\e[22m";
        /// Reset underline ANSI code (format strings with it)
        public const string UnUnderline = @"\e[24m";
        /// Reset invert ANSI code (format strings with it)
        public const string UnInvert = @"\e[27m";
        /// Reset hidden ANSI code (format strings with it)
        public const string UnHidden = @"\e[28m";

        /// Enable bold formatting without printing
        public static void SetBold() => Printer.Echo(Bold, "-e");
        /// Enable dim formatting without printing
        public static void SetDim() => Printer.Echo(Dim, "-e");
        /// Enable underline formatting without printing
        public static void SetUnderline() => Printer.Echo(Underline, "-e");
        /// Enable inverted formatting without printing
        public static void SetInvert() => Printer.Echo(Invert, "-e");
        /// Enable hidden formatting without printing
        public static void SetHidden() => Printer.Echo(Hidden, "-e");

        /// Disable bold formatting without printing
        public static void UnsetBold() => Printer.Echo(UnBold, "-e");
        /// Disable dim formatting without printing
        public static void UnsetDim() => Printer.Echo(UnDim, "-e");
        /// Disable underline formatting without printing
        public static void UnsetUnderline() => Printer.Echo(UnUnderline, "-e");
        /// Disable inverted formatting without printing
        public static void UnsetInvert() => Printer.Echo(UnInvert, "-e");
        /// Disable hidden formatting without printing
        public static void UnsetHidden() => Printer.Echo(UnHidden, "-e");
        /// Disable all formatting without printing
        public static void UnsetAll() => Printer.Echo(
            UnBold + UnDim + UnUnderline + UnInvert + UnHidden, "-e");

        /// Returns all available formatting options as an array
        public static string[] ToArray() => new string[]
        {
            Bold,
            Dim,
            Underline,
            Invert,
            Hidden,
            UnBold,
            UnDim,
            UnUnderline,
            UnInvert,
            UnHidden
        };
    }
}