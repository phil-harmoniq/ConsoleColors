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
    public static class Clr
    {
        static string _v = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        private static bool _linux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        private static bool _mac = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        private static Bash _bash = new Bash();
        public static string Bold { get; } = @"$(tput bold)";
        public static string Reset { get; } = @"$(tput sgr0)";
        public static string Black { get; } = @"$(tput setaf 0)";
        public static string Red { get; } = @"$(tput setaf 1)";
        public static string Green { get; } = @"$(tput setaf 2)";
        public static string Yellow { get; } = @"$(tput setaf 3)";
        public static string Blue { get; } = @"$(tput setaf 4)";
        public static string Magenta { get; } = @"$(tput setaf 5)";
        public static string Cyan { get; } = @"$(tput setaf 6)";
        public static string White { get; } = @"$(tput setaf 7)";
        private static string[] _colors = new string[]
        {
            Bold,
            Reset,
            Black,
            Red,
            Green,
            Yellow,
            Blue,
            Magenta,
            Cyan,
            White
        };
        private static string[] _regexColors = _colors.Select(c => Regex.Escape(c)).ToArray();

        public static void Write(string output)
        {
            if (_linux || _mac)
                _bash.Command($"echo -n {ParseString(output)}");
            else
                Console.Write(output);
        }

        public static void WriteLine(string output)
        {
            if (_linux || _mac)
                _bash.Command($"echo {ParseString(output)}");
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
                var inArray = Array.IndexOf(_colors.ToArray(), split[i]);
                
                if (inArray > -1)
                    parse.Add($"{_colors[inArray]}");
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
            _bash.Echo(Clr.Bold, "-n");
        }

        public static void SetReset()
        {
            _bash.Echo(Clr.Reset, "-n");
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
                    + $"{White} {_v}"
                    + $"{Reset}");
        }
    }
}
