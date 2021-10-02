# Flash String Converter

![visitors](https://visitor-badge.glitch.me/badge?page_id=vellt/Flash-String-Converter) 
![Web 1280 – 1]( https://img.shields.io/badge/-open%20source-green)

Null-safety string manipulating converter extensions `speed up` the development process. These extensions return null-safety values, but they can be modified with C# operators:

## remove null-safety
uses casting to avoid conversion errors:
```c#
int number = (int)"32".ToInt32();
```

## with null-safety
use ? operator or Nullable<> generic:
```c#
int? number = "32".ToInt32();
```

## Null checking
 In case of a conversion error, the extended string functions will return null. So it is worth checking its condition. 
```c#
if(number!=null) Console.WriteLine(number*2);
else throw new FormatException("Error"); 
```
or
```c#
Console.WriteLine(number * 2 ?? throw new FormatException("Error"));
```

## List of converter extensions:
- ToInt32
- ToDouble
- ToInt64
- ToDateTime
- ToBoolean

## How to use
- step 1: download the dll in the release <a target="_blank" href="https://github.com/vellt/Flash-String-Converter/releases/tag/v0.0.1" >tab</a>
- step 2: open a .NET Framework project with <a target="_blank" href="https://dotnet.microsoft.com/download/dotnet-framework/net472" >4.7.2</a> or newer.
- step 3: In solution exproler right click on the project name -> add -> reference -> Browse..-> select the downloaded dll file and OK.
- step 4: add the following to the namespaces:
```c# 
using FlashStringConverter; 
```

## Required dependencies 
- .NET Framework 4.7.2
