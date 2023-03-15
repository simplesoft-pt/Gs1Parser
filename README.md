# Gs1Parser
Lightweight parser for GS1 strings to be used in .NET applications.

## Installation
The library is available via [NuGet](https://www.nuget.org/packages?q=SimpleSoft.Gs1Parser) packages:

| NuGet | Description | Version |
| --- | --- | --- |
| [SimpleSoft.Gs1Parser](https://www.nuget.org/packages/simplesoft.gs1parser) | parser implementation for standard GS1 codes | [![NuGet](https://img.shields.io/nuget/vpre/simplesoft.gs1parser.svg)](https://www.nuget.org/packages/simplesoft.gs1parser) |

### Package Manager
```powershell
Install-Package SimpleSoft.Gs1Parser
```

### .NET CLI
```powershell
dotnet add package SimpleSoft.Gs1Parser
```

## Compatibility
This library is compatible with the following frameworks:

* `SimpleSoft.Gs1Parser`
  * .NET 5.0+;
  * .NET Framework 4.5+;
  * .NET Standard 1.0+;

## Usage
Parsing of GS1 strings are made via `Gs1Parser` instances, that can be configured via `Gs1ParserOptions` class.

```cs
var gs1Parser = new Gs1Parser(new Gs1ParserOptions
{
  Separator = ';'
});

var gs1 = gs1Parser.Parse("10AB111;17260630");

Assert.Equal("AB111", gs1[Gs1ApplicationIdentifierType.Batch].DataContent); // gs1["10"].DataContent
Assert.Equal("260630", gs1[Gs1ApplicationIdentifierType.UseBy].DataContent); // gs1["17"].DataContent
```

The library also provides both a default options and parser that can be used instead of initializing your own instances (the parser implementation is thread safe, 
you can use it as a singleton across your application):

```cs
Gs1ParserOptions.Default.Separator = ';';

var gs1 = Gs1Parser.Default.Parse("10AB111;17260630");

Assert.Equal("AB111", gs1[Gs1ApplicationIdentifierType.Batch].DataContent);
Assert.Equal("260630", gs1[Gs1ApplicationIdentifierType.UseBy].DataContent);
```

As a note, if you initialize a `Gs1Parser` instance without passing an options, it will use the default one.

```cs
// both lines are equivalent
new Gs1Parser();
new Gs1Parser(Gs1ParserOptions.Default);
```
