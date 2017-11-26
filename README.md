# Console Colors [![NuGet](https://img.shields.io/nuget/v/ConsoleColors.svg)](https://preview.nuget.org/packages/ConsoleColors) [![Build Status](https://travis-ci.org/phil-harmoniq/ConsoleColors.svg?branch=master)](https://travis-ci.org/phil-harmoniq/ConsoleColors)

[License]: https://img.shields.io/badge/License-MIT-blue.svg

Note: This library only works on Linux & MacOS currently. Alpha builds are subject to change.

<img src="http://i.imgur.com/fzoBQsG.png" width="287px" height="287px">

## Usage

Use string formatting/interpolation while calling `Printer.Write()` or `Printer.WriteLine()` to print with colors! Color properties are stored in the `Clr` class , formatting properties are in the `Frmt` class, and background color properties are in the `Bkgrd` class. To reset all color/formatting changes, use the `Reset.Code` property or call the `Reset.All()` class method.

## Installation

Use the .NET CLI to get [get this library off of Nuget!](https://www.nuget.org/packages/ConsoleColors)! Prereleases need an explicit version.

```bash
dotnet add package ConsoleColors -v 0.1.10-alpha
```

Or add the following to your .csproj:

```xml
<ItemGroup>
  <PackageReference Include="ConsoleColors" Version="0.1.9-alpha" />
</ItemGroup>
```

## Examples

```C#
Printer.SayHello();
Printer.WriteLine($@"This library uses {Clr.Cyan}{Frmt.Bold}Shell.NET{Clr.Default}!{Reset.Code}");
Printer.WriteLine($"{Bkgrd.Blue}{Frmt.Bold}I'm Mr. Meseeks Look at me!{Reset.Code}");
Printer.WriteLine(
    string.Format("{0}{4}C#{5} + {2}{4}*nix{5} = {3}{4}<3{5}",
    Clr.Magenta,
    Clr.White,
    Clr.Green,
    Clr.Red,
    Frmt.Bold,
    Reset.Code
));
```

Note: Remember to use Reset.All() to return back to default colors.

## Color Properties

* Clr.Default
* Clr.Black
* Clr.White
* Clr.Red
* Clr.Green
* Clr.Yellow
* Clr.Blue
* Clr.Magenta
* Clr.Cyan
* Clr.LtGray
* Clr.DrkGray
* Clr.LtRed
* Clr.LtGreen
* Clr.LtYellow
* Clr.LtBlue
* Clr.LtMagenta
* Clr.LtCyan

Note: All color properties have a corresponding class method. Examples:

* Clr.SetBlue()
* Clr.SetDefault()

## Formatting Properties

* Frmt.Bold
* Frmt.Dim
* Frmt.Underline
* Frmt.Invert
* Frmt.Hidden
* Frmt.UnBold
* Frmt.UnDim
* Frmt.UnUnderline
* Frmt.UnInvert
* Frmt.UnHidden

Note: All formatting properties have corresponding activation *and* deactivation class methods. Examples:

* Frmt.SetDim()
* Frmt.ResetDim()
* Frmt.Underline()
* Frmt.ResetAll()

## Reset Utility

* Reset.Code
* Reset.All()

## Background Color Properties

Same colors as the Clr class; contained in the Bkgrd class. Examples:

* Bkgrd.LtGray
* Bkgrd.White
* Bkgrd.SetBlue()
* Bkgrd.SetDefault()
