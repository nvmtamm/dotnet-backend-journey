# Day 02: Input and Output

## Goal

Learn to use `Console.ReadLine()` and `Console.WriteLine()` to interact with users.

## Topics

- `Console.Write()` and `Console.WriteLine()`
- `Console.ReadLine()` to capture string input
- Parsing numeric input with `decimal.TryParse()` and `int.TryParse()`
- Formatted output with string interpolation `$`
- Handling null with null-coalescing operator `??`

## Key Patterns

Read and parse input safely:

```csharp
Console.Write("Enter price: ");
string input = Console.ReadLine() ?? "0";
decimal price = decimal.TryParse(input, out decimal p) ? p : 0m;
```

Print formatted output:

```csharp
Console.WriteLine($"Total: ${total:F2}"); // F2 = 2 decimal places
```

## Practice Tasks

1. Run the program and enter: `"Clean Code"`, `"Robert C. Martin"`, `"Programming"`, `45.99`, `18`, `4`.
2. Change the tax rate to `0.1` (10%) and re-run.
3. Try entering an invalid price like `"abc"` and see what happens.
4. Enter an order quantity greater than stock to see the stock error message.
5. Add a prompt for `rating` (double) and display it in the Book Information section.

## Run

```bash
dotnet run
```