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
            Clr.SetCyan();
            Frmt.SetDim();
            Printer.WriteLine($"This library uses {Frmt.Bold}Shell.NET!");
            Reset.All();
            Printer.WriteLine(string.Format("{0}{4}C#{5} in {2}{4}Linux{5} is pretty {3}{4}cool!{5}",
                Clr.Magenta,
                Clr.White,
                Clr.Green,
                Clr.Yellow,
                Frmt.Bold,
                Reset.Code
            ));
            Printer.Write(string.Format("Some {0}{1}secret{4} {2}{3}Password: ",
                Clr.Red,
                Frmt.Underline,
                Clr.Green,
                Frmt.Bold,
                Reset.Code
            ));
            Frmt.SetHidden();
            var str = Console.ReadLine();
            Reset.All();

            Printer.WriteLine($"{Clr.DrkGray}You said {Clr.LtGray}{str}");
        }
    }
}
