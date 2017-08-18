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
            Printer.SayHello();
            Printer.WriteLine(
                $"This library uses {Clr.Cyan}{Frmt.Bold}Shell.NET{Clr.Default}!{Reset.Code}");
            Printer.WriteLine(
                $"{Bkgrd.Blue}{Frmt.Bold}I'm Mr. Meseeks Look at me!{Reset.Code}");
            Printer.WriteLine(
                string.Format("{0}{4}C#{5} + {2}{4}*nix{5} = {3}{4}<3{5}",
                Clr.Magenta,
                Clr.White,
                Clr.Green,
                Clr.Red,
                Frmt.Bold,
                Reset.Code
            ));
        }
    }
}
