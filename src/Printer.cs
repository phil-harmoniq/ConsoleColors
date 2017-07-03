using System;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Shell.NET;

namespace ConsoleColors
{
    /// ANSI-color compatible printer; use string formatting while calling Write() or WriteLine()
    public static class Printer
    {
        static string _v = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        private static bool _linux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        private static bool _mac = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        internal static Bash _bash = new Bash();
        private static string[] _regexColors = Clr.ToArray().Select(c => Regex.Escape(c)).ToArray();

        /// Print the given colorized string without a new line at the end
        public static void Write(string output)
        {
            if (_linux || _mac)
                _bash.Echo(output, "-en");
            else
                Console.Write(output);
        }

        /// Print the given colorized string with a new line at the end
        public static void WriteLine(string output)
        {
            if (_linux || _mac)
                _bash.Echo(output, "-e");
            else
                Console.Write(output);
        }

        /// Color print the library name and version
        public static void SayHello()
        {
            WriteLine($"{Frmt.Bold}"
                    + $"{Clr.Red}C"
                    + $"{Clr.Yellow}o"
                    + $"{Clr.Green}n"
                    + $"{Clr.Cyan}s"
                    + $"{Clr.Blue}o"
                    + $"{Clr.Magenta}l"
                    + $"{Clr.Red}e"
                    + $"{Clr.Yellow}C"
                    + $"{Clr.Green}o"
                    + $"{Clr.Cyan}l"
                    + $"{Clr.Blue}o"
                    + $"{Clr.Magenta}r"
                    + $"{Clr.Red}s"
                    + $"{Clr.White} {_v}"
                    + $"{Reset.Code}"
            );
        }
    }
}
