using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Shell.NET;

namespace ConsoleColors
{
    public static class Clr
    {
        private static Process _shell;
        private static bool _linux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        private static bool _mac = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        public static string Bold { get; } = "$(tput bold)";
        public static string Reset { get; } = "$(tput sgr0)";
        public static string Black { get; } = "$(tput setaf 0)";
        public static string Red { get; } = "$(tput setaf 1)";
        public static string Green { get; } = "$(tput setaf 2)";
        public static string Yellow { get; } = "$(tput setaf 3)";
        public static string Blue { get; } = "$(tput setaf 4)";
        public static string Magenta { get; } = "$(tput setaf 5)";
        public static string Cyan { get; } = "$(tput setaf 6)";
        public static string White { get; } = "$(tput setaf 7)";
        private static Bash _bash = new Bash();

        public static void Write(string output)
        {
            if (_linux || _mac)
                _bash.Echo(output, "-n");
            else
                Console.Write(output);
        }

        public static void WriteLine(string output)
        {
            if (_linux || _mac)
                _bash.Echo(output);
            else
                Console.Write(output);
        }

        public static void SayHello()
        {
            WriteLine($"{Bold}"
                    + $"{Red}C"
                    + $"{Yellow}o"
                    + $"{Green}n"
                    + $"{Cyan}s"
                    + $"{Blue}o"
                    + $"{Magenta}l"
                    + $"{Red}e"
                    + $"{Yellow}C"
                    + $"{Green}o"
                    + $"{Cyan}l"
                    + $"{Blue}o"
                    + $"{Magenta}r"
                    + $"{Red}s"
                    + $"{Reset}");
        }
    }
}
