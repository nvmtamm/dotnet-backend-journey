Console.WriteLine("BookVerse - Day 05: Switch");
Console.WriteLine("===========================");

Console.WriteLine();
Console.WriteLine("Menu");
Console.WriteLine("----");
Console.WriteLine("1) List all books");
Console.WriteLine("2) Add a new book");
Console.WriteLine("3) Update a book");
Console.WriteLine("4) Delete a book");
Console.WriteLine("5) Search a book");
Console.WriteLine();

Console.Write("Choose an option (1-5): ");
string? raw = Console.ReadLine();
int menuChoice = int.TryParse(raw, out int parsed) ? parsed : 0;

Console.WriteLine();
Console.WriteLine("Result");
Console.WriteLine("------");

string action;
string description;

switch (menuChoice)
{
    case 1:
        action = "List";
        description = "Showing all books in the catalog.";
        break;
    case 2:
    case 3:
    case 4:
        action = "Write";
        description = menuChoice == 2
            ? "Opening the Add Book form."
            : menuChoice == 3
                ? "Opening the Update Book form."
                : "Opening the Delete Book form.";
        break;
    case 5:
        action = "Search";
        description = "Opening the Search Book form.";
        break;
    default:
        action = "Invalid";
        description = "Invalid option. Please choose between 1 and 5.";
        break;
}

Console.WriteLine($"Action: {action}");
Console.WriteLine($"Detail: {description}");

Console.WriteLine();
Console.WriteLine("Switch Expression (C# 8+)");
Console.WriteLine("--------------------------");

string category = menuChoice switch
{
    1 => "Browse",
    2 or 3 or 4 => "Manage",
    5 => "Search",
    _ => "Unknown"
};

Console.WriteLine($"Category: {category}");

Console.WriteLine();
Console.WriteLine("Switch Expression with Tuple");
Console.WriteLine("---------------------------");

string tier;
decimal price = 39.99m;
bool isMember = true;

(tier, decimal discount) = (price, isMember) switch
{
    ( >= 50m, true ) => ("Premium VIP", 0.25m),
    ( >= 50m, false ) => ("Premium", 0.10m),
    ( >= 20m, true ) => ("Standard VIP", 0.15m),
    ( >= 20m, false ) => ("Standard", 0.05m),
    _ => ("Budget", 0m)
};

decimal finalPrice = price - (price * discount);
Console.WriteLine($"Price: ${price:F2}, Member: {isMember}");
Console.WriteLine($"Tier: {tier}");
Console.WriteLine($"Discount: {discount:P0}");
Console.WriteLine($"Final Price: ${finalPrice:F2}");