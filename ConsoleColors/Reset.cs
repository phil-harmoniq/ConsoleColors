namespace ConsoleColors
{
    public class Reset
    {
        public static string Code = @"\e[0m";
        public static void All() => Printer._bash.Echo(Code, "-en");
    }
}