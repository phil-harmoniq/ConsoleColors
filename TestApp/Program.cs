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
            Clr.WriteLine($"This library uses {Clr.Bold}{Clr.Cyan}Shell.NET{Clr.Reset}!");
        }
    }
}
