using System;
using System.Reflection;
using System.Diagnostics;
using ConsoleColors;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Clr.SayHello();
            Clr.WriteLine($"Th*is 'libra#r$y ) uses {Clr.Bold}{Clr.Cyan}Shell.NET{Clr.Reset}!");
        }
    }
}
