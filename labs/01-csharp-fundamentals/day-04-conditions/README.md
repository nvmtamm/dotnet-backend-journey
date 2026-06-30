# Day 04: Conditions

## Goal

Practice `if`, `else if`, `else`, and logical operators (`&&`, `||`) through a BookVerse bookstore example.

## Topics

- `if` statement
- `else if` and `else`
- Comparison operators: `<`, `<=`, `>`, `>=`, `==`, `!=`
- Logical operators: `&&`, `||`
- Nested conditions
- Combining multiple boolean expressions

## Key Patterns

Use `else if` for a chain of exclusive conditions:

```csharp
if (stockQuantity <= 0)
{
    Console.WriteLine("Out of stock");
}
else if (stockQuantity < 5)
{
    Console.WriteLine("Low stock");
}
else
{
    Console.WriteLine("In stock");
}
```

Use parentheses in complex boolean logic for readability:

```csharp
if (isMember && rating >= 4.5)
{
    discountRate = 0.20m;
}
```

## Practice Tasks

1. Run the program. With the default values you should see: Low stock, Standard book, VIP discount 20%, and Parental guidance.
2. Change `stockQuantity` to `0`, then to `10`, and observe the availability output.
3. Change `isMember` to `false` and `rating` to `4.2` to trigger the Bestseller discount path.
4. Change `customerAge` to `10` and verify the Children's section message.
5. Add a new condition: if `rating >= 4.8`, print `"Editor's Pick"` before the discount block.
6. Add a check: if `stockQuantity == 0` and `!isMember`, print `"Notify me when available"`.

## Run

```bash
dotnet run
```