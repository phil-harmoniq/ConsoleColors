using System;
using System.Reflection;
using System.Diagnostics;
using ConsoleColors;

namespace TestApp
{
    class Program
    {
        static string version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

        static void Main(string[] args)
        {
            Clr.WriteLine($"This library uses {Clr.Cyan}Shell.NET{Clr.Reset}!");
        }
    }
}
