# Day 03: Operators and Expressions

## Goal

Practice arithmetic, comparison, and logical operators through a BookVerse discount and order calculation.

## Topics

- Arithmetic operators: `+`, `-`, `*`, `/`
- Assignment operators: `=`, compound assignments
- Comparison operators: `>`, `<`, `>=`, `<=`, `==`, `!=`
- Logical operators: `&&`, `||`, `!`
- Ternary operator `? :`
- Compound assignment with multiplication and subtraction
- String interpolation `$`
- Currency format specifier `:C` and percentage `:P0`

## Key Patterns

Ternary operator for simple conditional assignment:

```csharp
string status = stock > 0 ? "In stock" : "Out of stock";
```

Logical AND for compound conditions:

```csharp
bool canOrder = orderQty > 0 && orderQty <= stockQty;
```

## Practice Tasks

1. Run the program and verify all output sections.
2. Change `discountRate` to `0.25` and observe the new totals.
3. Set `orderQuantity` to `20` (exceeds stock) and check the status.
4. Change `stockQuantity` to `3` and see how `isLowStock` affects the output.
5. Add a new variable `decimal shippingFee = 5.99m;` and include it in the order total calculation.
6. Calculate and print the profit margin: `(discountedUnitPrice - unitPrice * 0.7) / discountedUnitPrice * 100`.

## Run

```bash
dotnet run
```