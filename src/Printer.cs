using System;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleColors
{
    /// ANSI-color compatible printer; use string formatting while calling Write() or WriteLine()
    public static class Printer
    {
        private static string _assembly { get; }
        private static string _v { get; }

        static Printer()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                throw new PlatformNotSupportedException();

            _assembly = Assembly.GetExecutingAssembly().Location;
            _v = FileVersionInfo.GetVersionInfo(_assembly).ProductVersion;
        }

        /// Print the given colorized string without a new line at the end
        public static void Write(string output) =>
            Echo(output, "-ne");

        /// Print the given colorized string with a new line at the end
        public static void WriteLine(string output) =>
            Echo(output, "-e");

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

        internal static void Echo(string input, string flags)
        {
            // Single-quotes without a closer will cause bash to hang. Need to escape it.
            input = input.Replace("'", @"'\''");

            using (var bash = new Process { StartInfo = BashInfo(input, flags) })
            {
                bash.Start();
                bash.WaitForExit();
                bash.Close();
            }
        }

        private static ProcessStartInfo BashInfo(string input, string flags) => new ProcessStartInfo
        {
            FileName = "bash",
            Arguments = $"-c \"echo {flags} '{input}'\"",
            RedirectStandardInput = false,
            RedirectStandardOutput = false,
            RedirectStandardError = false,
            UseShellExecute = false,
            CreateNoWindow = true,
            ErrorDialog = false
        };
    }
}
