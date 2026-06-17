Console.WriteLine("BookVerse - Day 01: Variables and Data Types");
Console.WriteLine("============================================");

string bookTitle = "Clean Code";
string authorName = "Robert C. Martin";
int publicationYear = 2008;
decimal price = 45.99m;
int stockQuantity = 12;
double rating = 4.8;
bool isAvailable = stockQuantity > 0;
char shelfCode = 'A';

const decimal taxRate = 0.08m;

decimal taxAmount = price * taxRate;
decimal finalPrice = price + taxAmount;

Console.WriteLine();
Console.WriteLine("Book Information");
Console.WriteLine($"Title: {bookTitle}");
Console.WriteLine($"Author: {authorName}");
Console.WriteLine($"Publication Year: {publicationYear}");
Console.WriteLine($"Price: ${price}");
Console.WriteLine($"Tax Rate: {taxRate:P0}");
Console.WriteLine($"Final Price: ${finalPrice}");
Console.WriteLine($"Stock Quantity: {stockQuantity}");
Console.WriteLine($"Rating: {rating}/5");
Console.WriteLine($"Available: {isAvailable}");
Console.WriteLine($"Shelf Code: {shelfCode}");

Console.WriteLine();
Console.WriteLine("Type Inference with var");
var categoryName = "Programming";
var soldQuantity = 3;
var totalRevenue = price * soldQuantity;

Console.WriteLine($"Category: {categoryName}");
Console.WriteLine($"Sold Quantity: {soldQuantity}");
Console.WriteLine($"Total Revenue: ${totalRevenue}");

Console.WriteLine();
Console.WriteLine("Type Conversion");
string stockText = "20";
int parsedStock = int.Parse(stockText);
decimal discountedPrice = price - 5;

Console.WriteLine($"Stock Text: {stockText}");
Console.WriteLine($"Parsed Stock: {parsedStock}");
Console.WriteLine($"Discounted Price: ${discountedPrice}");

Console.WriteLine();
Console.WriteLine("Safe Parsing");
string userInput = "15";

if (int.TryParse(userInput, out int requestedQuantity))
{
    Console.WriteLine($"Requested Quantity: {requestedQuantity}");
}
else
{
    Console.WriteLine("Invalid quantity input.");
}

