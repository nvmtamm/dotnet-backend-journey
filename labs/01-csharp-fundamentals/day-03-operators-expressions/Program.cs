Console.WriteLine("BookVerse - Day 03: Operators and Expressions");
Console.WriteLine("==============================================");

string bookTitle = "Clean Code";
string authorName = "Robert C. Martin";
string categoryName = "Programming";
decimal unitPrice = 45.99m;
int stockQuantity = 18;
int orderQuantity = 4;

const decimal discountRate = 0.15m;
const decimal taxRate = 0.08m;

decimal discountAmount = unitPrice * discountRate;

decimal discountedUnitPrice = unitPrice - discountAmount;

decimal subtotal = discountedUnitPrice * orderQuantity;

decimal taxAmount = subtotal * taxRate;

decimal orderTotal = subtotal + taxAmount;

decimal originalStockValue = unitPrice * stockQuantity;
decimal discountedStockValue = discountedUnitPrice * stockQuantity;

bool canFulfillOrder = orderQuantity > 0 && orderQuantity <= stockQuantity;

int remainingStock = canFulfillOrder ? stockQuantity - orderQuantity : stockQuantity;

bool isLowStock = remainingStock <= 5;
string orderStatus = canFulfillOrder ? "Ready to fulfill" : "Not enough stock";
string stockStatus = isLowStock ? "Low stock" : "Healthy stock";

Console.WriteLine();
Console.WriteLine("Book Information");
Console.WriteLine("----------------");
Console.WriteLine($"Title: {bookTitle}");
Console.WriteLine($"Author: {authorName}");
Console.WriteLine($"Category: {categoryName}");
Console.WriteLine($"Original Unit Price: {unitPrice:C}");
Console.WriteLine($"Stock Quantity: {stockQuantity}");
Console.WriteLine($"Order Quantity: {orderQuantity}");

Console.WriteLine();
Console.WriteLine("Discount Calculation");
Console.WriteLine("--------------------");
Console.WriteLine($"Discount Rate: {discountRate:P0}");
Console.WriteLine($"Discount Amount: {discountAmount:C}");
Console.WriteLine($"Discounted Unit Price: {discountedUnitPrice:C}");

Console.WriteLine();
Console.WriteLine("Order Total");
Console.WriteLine("-----------");
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Tax Rate: {taxRate:P0}");
Console.WriteLine($"Tax Amount: {taxAmount:C}");
Console.WriteLine($"Order Total: {orderTotal:C}");
Console.WriteLine($"Order Status: {orderStatus}");

Console.WriteLine();
Console.WriteLine("Stock Value");
Console.WriteLine("-----------");
Console.WriteLine($"Original Stock Value: {originalStockValue:C}");
Console.WriteLine($"Discounted Stock Value: {discountedStockValue:C}");
Console.WriteLine($"Remaining Stock: {remainingStock}");
Console.WriteLine($"Stock Status: {stockStatus}");