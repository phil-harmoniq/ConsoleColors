# Console Colors [![License][License]](LICENSE.md) [![Nuget][Nuget]](https://www.nuget.org/packages/ConsoleColors)

[License]: https://img.shields.io/badge/License-MIT-blue.svg

[Nuget]: https://img.shields.io/badge/Nuget-0.1.2-blue.svg

Disclaimer: This library only works on Linux & MacOS currently

![](http://imgur.com/RqvnNDW.png)

## Usage

Several color properties are available in the Clr class. Simply use string interpolation while calling `Clr.Write()` or `Clr.WriteLine()` to print with colors!

```C#
Clr.WriteLine($"This library uses {Clr.Bold}{Clr.Cyan}Shell.NET{Clr.Reset}!");
Clr.WriteLine($"Hey! {Clr.Cyan}This is pretty {Clr.Bold}cool!{Clr.Reset}");
```
Note: Remeber to use Clr.Reset to return back to default colors.

[Download this library off of Nuget!](https://www.nuget.org/packages/ConsoleColors)

## Available Color Properties
* Clr.Bold
* Clr.Reset
* Clr.Black
* Clr.Red
* Clr.Green
* Clr.Yellow
* Clr.Blue
* Clr.Magenta
* Clr.Cyan
* Clr.White
