namespace ConsoleColors
{
    public static class Frmt
    {
        public static readonly string Bold = @"\e[1m";
        public static readonly string Dim = @"\e[2m";
        public static readonly string Underline = @"\e[4m";
        public static readonly string Blink = @"\e[5m";
        public static readonly string Invert = @"\e[7m";
        public static readonly string Hidden = @"\e[8m";

        public static readonly string UnBold = @"\e[21m";
        public static readonly string UnDim = @"\e[22m";
        public static readonly string UnUnderline = @"\e[24m";
        public static readonly string UnBlink = @"\e[25m";
        public static readonly string UnInvert = @"\e[27m";
        public static readonly string UnHidden = @"\e[28m";

        public static void SetBold() => Printer._bash.Echo(Bold, "-en");
        public static void SetDim() => Printer._bash.Echo(Dim, "-en");
        public static void SetUnderline() => Printer._bash.Echo(Underline, "-en");
        public static void SetBlink() => Printer._bash.Echo(Blink, "-en");
        public static void SetInvert() => Printer._bash.Echo(Invert, "-en");
        public static void SetHidden() => Printer._bash.Echo(Hidden, "-en");

        public static void ResetBold() => Printer._bash.Echo(UnBold, "-en");
        public static void ResetDim() => Printer._bash.Echo(UnDim, "-en");
        public static void ResetUnderline() => Printer._bash.Echo(UnUnderline, "-en");
        public static void ResetBlink() => Printer._bash.Echo(UnBlink, "-en");
        public static void ResetInvert() => Printer._bash.Echo(UnInvert, "-en");
        public static void ResetHidden() => Printer._bash.Echo(UnHidden, "-en");
        public static void ResetAll() => Printer._bash.Echo(
            UnBold + UnDim + UnUnderline + UnBlink + UnInvert + UnHidden);

        public static string[] ToArray() => new string[]
        {
            Bold,
            Dim,
            Underline,
            Blink,
            Invert,
            Hidden,
            UnBold,
            UnDim,
            UnUnderline,
            UnBlink,
            UnInvert,
            UnHidden
        };
    }
}