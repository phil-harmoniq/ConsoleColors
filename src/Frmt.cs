namespace ConsoleColors
{
    /// Container class for all available formatting options
    public static class Frmt
    {
        /// Bold ANSI code (format strings with it)
        public static readonly string Bold = @"\e[1m";
        /// Dim ANSI code (format strings with it)
        public static readonly string Dim = @"\e[2m";
        /// Underline ANSI code (format strings with it)
        public static readonly string Underline = @"\e[4m";
        /// Invert ANSI code (format strings with it)
        public static readonly string Invert = @"\e[7m";
        /// Hidden ANSI code (format strings with it)
        public static readonly string Hidden = @"\e[8m";

        /// Reset bold ANSI code (format strings with it)
        public static readonly string UnBold = @"\e[21m";
        /// Reset dim ANSI code (format strings with it)
        public static readonly string UnDim = @"\e[22m";
        /// Reset underline ANSI code (format strings with it)
        public static readonly string UnUnderline = @"\e[24m";
        /// Reset invert ANSI code (format strings with it)
        public static readonly string UnInvert = @"\e[27m";
        /// Reset hidden ANSI code (format strings with it)
        public static readonly string UnHidden = @"\e[28m";

        /// Enable bold formatting without printing
        public static void SetBold() => Printer._bash.Echo(Bold, "-en");
        /// Enable dim formatting without printing
        public static void SetDim() => Printer._bash.Echo(Dim, "-en");
        /// Enable underline formatting without printing
        public static void SetUnderline() => Printer._bash.Echo(Underline, "-en");
        /// Enable inverted formatting without printing
        public static void SetInvert() => Printer._bash.Echo(Invert, "-en");
        /// Enable hidden formatting without printing
        public static void SetHidden() => Printer._bash.Echo(Hidden, "-en");

        /// Disable bold formatting without printing
        public static void ResetBold() => Printer._bash.Echo(UnBold, "-en");
        /// Disable dim formatting without printing
        public static void ResetDim() => Printer._bash.Echo(UnDim, "-en");
        /// Disable underline formatting without printing
        public static void ResetUnderline() => Printer._bash.Echo(UnUnderline, "-en");
        /// Disable inverted formatting without printing
        public static void ResetInvert() => Printer._bash.Echo(UnInvert, "-en");
        /// Disable hidden formatting without printing
        public static void ResetHidden() => Printer._bash.Echo(UnHidden, "-en");
        /// Disable all formatting without printing
        public static void ResetAll() => Printer._bash.Echo(
            UnBold + UnDim + UnUnderline + UnInvert + UnHidden);

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