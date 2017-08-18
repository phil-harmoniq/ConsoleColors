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
        readonly static string _assembly = Assembly.GetExecutingAssembly().Location;
        readonly static string _v = FileVersionInfo.GetVersionInfo(_assembly).ProductVersion;

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
            using (var bash = new Process { StartInfo = BashInfo })
            {
                // Single-quotes without a closer will cause bash to hang. Need to escape it.
                input = input.Replace("'", @"'\''");

                bash.Start();
                bash.StandardInput.WriteLine("echo " + flags + " '" + $@"{input}" + "'; exit");
                bash.WaitForExit();
                bash.Close();
            }
        }

        private static ProcessStartInfo BashInfo => new ProcessStartInfo
        {
            FileName = "bash",
            RedirectStandardInput = true,
            RedirectStandardOutput = false,
            RedirectStandardError = false,
            UseShellExecute = false,
            CreateNoWindow = true,
            ErrorDialog = false
        };
    }
}
