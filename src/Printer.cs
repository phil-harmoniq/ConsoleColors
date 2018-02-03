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
            _assembly = Assembly.GetExecutingAssembly().Location;
            _v = FileVersionInfo.GetVersionInfo(_assembly).ProductVersion;
        }

        /// Print the given colorized string without a new line at the end
        public static void Write(string output) =>
            Printf(output, newLine: false);

        /// Print the given colorized string with a new line at the end
        public static void WriteLine(string output) =>
            Printf(output);

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

        internal static void Printf(string input, bool newLine = true)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                throw new PlatformNotSupportedException();
            
            // Single-quotes without a closer will cause bash to hang. Need to escape it.
            input = input.Replace("'", @"'\''");

            if (newLine) input += Environment.NewLine;

            using (var bash = new Process { StartInfo = BashInfo(input) })
            {
                bash.Start();
                bash.WaitForExit();
                bash.Close();
            }
        }

        private static ProcessStartInfo BashInfo(string input) => new ProcessStartInfo
        {
            FileName = "bash",
            Arguments = $"-c \"printf '{input}'\"",
            RedirectStandardInput = false,
            RedirectStandardOutput = false,
            RedirectStandardError = false,
            UseShellExecute = false,
            CreateNoWindow = true,
            ErrorDialog = false
        };
    }
}
