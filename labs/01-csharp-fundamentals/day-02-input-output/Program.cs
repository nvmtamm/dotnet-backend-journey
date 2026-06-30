Console.WriteLine("BookVerse - Day 02: Input and Output");
Console.WriteLine("======================================");

Console.Write("Enter book title: ");
string bookTitle = Console.ReadLine() ?? "Unknown";

Console.Write("Enter author name: ");
string authorName = Console.ReadLine() ?? "Unknown";

Console.Write("Enter category: ");
string categoryName = Console.ReadLine() ?? "General";

Console.Write("Enter unit price ($): ");
string priceInput = Console.ReadLine() ?? "0";
decimal unitPrice = decimal.TryParse(priceInput, out decimal p) ? p : 0m;

Console.Write("Enter stock quantity: ");
string stockInput = Console.ReadLine() ?? "0";
int stockQuantity = int.TryParse(stockInput, out int s) ? s : 0;

Console.Write("Enter order quantity: ");
string orderInput = Console.ReadLine() ?? "0";
int orderQuantity = int.TryParse(orderInput, out int o) ? o : 0;

Console.WriteLine();
Console.WriteLine("Book Information");
Console.WriteLine("----------------");
Console.WriteLine($"Title: {bookTitle}");
Console.WriteLine($"Author: {authorName}");
Console.WriteLine($"Category: {categoryName}");
Console.WriteLine($"Unit Price: ${unitPrice:F2}");
Console.WriteLine($"Stock Quantity: {stockQuantity}");
Console.WriteLine($"Order Quantity: {orderQuantity}");

if (orderQuantity > 0 && orderQuantity <= stockQuantity)
{
    decimal subtotal = unitPrice * orderQuantity;
    decimal taxRate = 0.08m;
    decimal taxAmount = subtotal * taxRate;
    decimal total = subtotal + taxAmount;

    Console.WriteLine();
    Console.WriteLine("Order Summary");
    Console.WriteLine("-------------");
    Console.WriteLine($"Subtotal: ${subtotal:F2}");
    Console.WriteLine($"Tax (8%): ${taxAmount:F2}");
    Console.WriteLine($"Total: ${total:F2}");
}
else if (orderQuantity > stockQuantity)
{
    Console.WriteLine();
    Console.WriteLine("Order Summary");
    Console.WriteLine("-------------");
    Console.WriteLine("Not enough stock to fulfill the order.");
}