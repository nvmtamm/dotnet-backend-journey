# Day 05: Switch

## Goal

Practice the classic `switch` statement and the modern `switch` expression using BookVerse menu and pricing examples.

## Topics

- `switch` statement with `case` and `break`
- Multiple labels falling through to the same code (`case 2: case 3:`)
- `default` branch
- Switch expression `=>` (C# 8+)
- Pattern combinators: `or`, `and`, relational patterns, tuple patterns
- Discard `_`

## Key Patterns

Classic switch:

```csharp
switch (menuChoice)
{
    case 1:
        Console.WriteLine("List");
        break;
    case 2:
    case 3:
    case 4:
        Console.WriteLine("Write");
        break;
    default:
        Console.WriteLine("Unknown");
        break;
}
```

Switch expression with tuple pattern:

```csharp
string tier = (price, isMember) switch
{
    ( >= 50m, true ) => "Premium VIP",
    ( >= 20m, true ) => "Standard VIP",
    _ => "Budget"
};
```

## Practice Tasks

1. Run the program. Type `1`, then `2`, then `9` to see how each switch branch behaves.
2. Change `price` to `59.99` and confirm `Premium VIP` is selected.
3. Set `isMember = false` with `price = 29.99` and verify `Standard`.
4. Add a new switch expression that maps a `rating` (double) to a label:
   - `>= 4.8` → `"Editor's Pick"`
   - `>= 4.5` → `"Recommended"`
   - `>= 4.0` → `"Average"`
   - else → `"Below Average"`
5. Add a `case` that prints `"Exiting..."` when the user types `0`.

## Run

```bash
dotnet run
```