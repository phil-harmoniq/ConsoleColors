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
    public static class Printer
    {
        static string _v = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        private static bool _linux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        private static bool _mac = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        internal static Bash _bash = new Bash();
        private static string[] _regexColors = Clr.ToArray().Select(c => Regex.Escape(c)).ToArray();

        public static void Write(string output)
        {
            if (_linux || _mac)
                _bash.Echo(output, "-en");
            else
                Console.Write(output);
        }

        public static void WriteLine(string output)
        {
            if (_linux || _mac)
                _bash.Echo(output, "-e");
            else
                Console.Write(output);
        }

        private static string ParseString(string input)
        {
            var pattern = $"({string.Join("|", _regexColors)})";
            var split = Regex.Split(input, pattern);
            var parse = new List<string>();

            for (var i = 0; i < split.Length; i++)
            {
                var inArray = Array.IndexOf(Clr.ToArray(), split[i]);
                
                if (inArray > -1)
                    parse.Add($"{Clr.ToArray()[inArray]}");
                else
                    parse.Add($"'{Sanitize(split[i])}'");
            }

            return string.Join("", parse);
        }

        private static string Sanitize(string input)
        {
            input = input.Replace(@"'", @"'\''");
            return input;
        }

        public static void SetBold()
        {
            _bash.Echo(Frmt.Bold, "-n");
        }

        public static void SetReset()
        {
            _bash.Echo(Clr.Default, "-n");
        }

        public static void SetBlack()
        {
            _bash.Echo(Clr.Black, "-n");
        }

        public static void SetRed()
        {
            _bash.Echo(Clr.Red, "-n");
        }

        public static void SetGreen()
        {
            _bash.Echo(Clr.Green, "-n");
        }

        public static void SetYellow()
        {
            _bash.Echo(Clr.Yellow, "-n");
        }

        public static void SetBlue()
        {
            _bash.Echo(Clr.Blue, "-n");
        }

        public static void SetMagenta()
        {
            _bash.Echo(Clr.Magenta, "-n");
        }

        public static void SetCyan()
        {
            _bash.Echo(Clr.Cyan, "-n");
        }

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
