namespace ConsoleColors
{
    /// Container class for resetting all formatting and colors
    public class Reset
    {
        /// All attribute reset ANSI code (format strings with it)
        public static string Code = @"\e[0m";
        /// Disable all formatting and reset colors without printing
        public static void All() => Printer._bash.Echo(Code, "-en");
    }
}