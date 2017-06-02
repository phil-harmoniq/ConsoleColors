using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleColors
{
    public static class Clr
    {
        private static Process _shell;
        private static bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        public const string Bold = "$(tput bold)";
        public const string Reset = "$(tput sgr0)";
        public const string Black = "$(tput setaf 0)";
        public const string Red = "$(tput setaf 1)";
        public const string Green = "$(tput setaf 2)";
        public const string Yellow = "$(tput setaf 3)";
        public const string Blue = "$(tput setaf 4)";
        public const string Magenta = "$(tput setaf 5)";
        public const string Cyan = "$(tput setaf 6)";
        public const string White = "$(tput setaf 7)";
        private static ProcessStartInfo _startInfo;

        public static void Write(string output)
        {
            if (isLinux)
            {
                StartShell(NewProcess(output, "n"));
                _shell.WaitForExit();
                CloseShell();
            }
            else
            {
                Console.Write(output);
            }
        }

        public static void WriteLine(string output)
        {
            if (isLinux)
            {
                StartShell(NewProcess(output));
                _shell.WaitForExit();
                CloseShell();
            }
            else
            {
                Console.WriteLine(output);
            }
        }

        private static void StartShell(ProcessStartInfo info)
        {
            _shell = new Process { StartInfo = info };
            _shell.Start();
        }

        private static void CloseShell()
        {
            _shell.Close();
        }

        private static ProcessStartInfo NewProcess(string output, string flag = null)
        {
            return new ProcessStartInfo
            {
                FileName = $"echo {flag} {output}",
                RedirectStandardInput = false,
                UseShellExecute = true,
                CreateNoWindow = true,
                ErrorDialog = false
            };
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
