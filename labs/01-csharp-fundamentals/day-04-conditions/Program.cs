Console.WriteLine("BookVerse - Day 04: Conditions");
Console.WriteLine("================================");

string bookTitle = "The Pragmatic Programmer";
decimal price = 39.99m;
int stockQuantity = 3;
double rating = 4.7;
bool isMember = true;

Console.WriteLine();
Console.WriteLine("Book Information");
Console.WriteLine($"Title: {bookTitle}");
Console.WriteLine($"Price: ${price}");
Console.WriteLine($"Stock Quantity: {stockQuantity}");
Console.WriteLine($"Rating: {rating}/5");
Console.WriteLine($"Is Member: {isMember}");

Console.WriteLine();
Console.WriteLine("Availability Check");
if (stockQuantity <= 0)
{
    Console.WriteLine("Status: Out of stock");
}
else if (stockQuantity < 5)
{
    Console.WriteLine("Status: Low stock — please restock soon");
}
else
{
    Console.WriteLine("Status: In stock");
}

Console.WriteLine();
Console.WriteLine("Pricing Tier");
if (price < 20m)
{
    Console.WriteLine("Tier: Budget book");
}
else if (price < 50m)
{
    Console.WriteLine("Tier: Standard book");
}
else
{
    Console.WriteLine("Tier: Premium book");
}

Console.WriteLine();
Console.WriteLine("Discount Rule");
decimal discountRate;
if (isMember && rating >= 4.5)
{
    discountRate = 0.20m;
    Console.WriteLine("Eligible: VIP member discount 20%");
}
else if (isMember)
{
    discountRate = 0.10m;
    Console.WriteLine("Eligible: Member discount 10%");
}
else if (rating >= 4.5)
{
    discountRate = 0.05m;
    Console.WriteLine("Eligible: Bestseller discount 5%");
}
else
{
    discountRate = 0m;
    Console.WriteLine("Eligible: No discount");
}

decimal finalPrice = price - (price * discountRate);
Console.WriteLine($"Final Price: ${finalPrice:F2}");

Console.WriteLine();
Console.WriteLine("Purchase Eligibility");
bool canPurchase = stockQuantity > 0 && finalPrice > 0m;
if (canPurchase)
{
    Console.WriteLine("Customer can purchase this book.");
}
else
{
    Console.WriteLine("Customer cannot purchase this book right now.");
}

Console.WriteLine();
Console.WriteLine("Nested Conditions");
int customerAge = 17;
if (customerAge >= 18)
{
    Console.WriteLine("Customer is an adult.");
}
else
{
    Console.WriteLine("Customer is a minor.");
    if (customerAge >= 13)
    {
        Console.WriteLine("Parental guidance suggested for technical topics.");
    }
    else
    {
        Console.WriteLine("Children's section recommended.");
    }
}