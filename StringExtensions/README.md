# String Utilities

A .NET library that provides extension methods for the string class.

## Features

- `StartsWithUpperCase()`: Checks if a string starts with an uppercase letter.

## Usage

```csharp
using StringUtilities;

string text1 = "Hello";
bool isUpperCase1 = text1.StartsWithUpperCase(); // Returns true

string text2 = "hello";
bool isUpperCase2 = text2.StartsWithUpperCase(); // Returns false
```

## Requirements

- .NET 8.0 or higher
