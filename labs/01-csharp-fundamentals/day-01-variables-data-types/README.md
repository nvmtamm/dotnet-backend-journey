# Day 01: Variables and Data Types

## Goal

Practice basic C# variables and data types through a small BookVerse example.

## Topics

- `string`
- `int`
- `decimal`
- `double`
- `bool`
- `char`
- `const`
- `var`
- Basic calculation
- Basic type conversion
- Safe parsing with `int.TryParse`

## Notes

Use `decimal` for money because it is more suitable for financial values than `double`.

Use `var` when the right side clearly shows the data type:

```csharp
var categoryName = "Programming";
var soldQuantity = 3;
```

Avoid using `var` when it makes the code harder to read.

## Practice Tasks

1. Change the book title, author, price, and stock quantity.
2. Add a new variable named `publisher`.
3. Add a new variable named `discountPercent`.
4. Calculate the final price after discount and tax.
5. Try changing `userInput` to an invalid value like `"abc"` and observe the result.

## Run

```bash
dotnet run
```

