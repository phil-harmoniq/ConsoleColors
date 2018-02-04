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
        public static void SetBold() => Printer.Printf(Bold, newLine: false);
        /// Enable dim formatting without printing
        public static void SetDim() => Printer.Printf(Dim, newLine: false);
        /// Enable underline formatting without printing
        public static void SetUnderline() => Printer.Printf(Underline, newLine: false);
        /// Enable inverted formatting without printing
        public static void SetInvert() => Printer.Printf(Invert, newLine: false);
        /// Enable hidden formatting without printing
        public static void SetHidden() => Printer.Printf(Hidden, newLine: false);

        /// Disable bold formatting without printing
        public static void UnsetBold() => Printer.Printf(UnBold, newLine: false);
        /// Disable dim formatting without printing
        public static void UnsetDim() => Printer.Printf(UnDim, newLine: false);
        /// Disable underline formatting without printing
        public static void UnsetUnderline() => Printer.Printf(UnUnderline, newLine: false);
        /// Disable inverted formatting without printing
        public static void UnsetInvert() => Printer.Printf(UnInvert, newLine: false);
        /// Disable hidden formatting without printing
        public static void UnsetHidden() => Printer.Printf(UnHidden, newLine: false);
        /// Disable all formatting without printing
        public static void UnsetAll() => Printer.Printf(
            UnBold + UnDim + UnUnderline + UnInvert + UnHidden, newLine: false);

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