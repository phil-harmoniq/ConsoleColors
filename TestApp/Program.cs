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
            Clr.WriteLine(string.Format("{0}{4}C#{5} in {2}{4}Linux{5} is pretty {3}{4}cool!{5}",
                Clr.Magenta,
                Clr.White,
                Clr.Green,
                Clr.Yellow,
                Clr.Bold,
                Clr.Reset
            ));
        }
    }
}
