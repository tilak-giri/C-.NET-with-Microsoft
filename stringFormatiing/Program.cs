// string first = "Hello";
// string second = "World";

// Console.WriteLine("{0} {1}!", first, second);
// Console.WriteLine("{0} {0} {0}", first, second);


// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), salePrice);

// yourDiscount += $"A discount of {((price-salePrice)/price):P2}";
// Console.WriteLine(yourDiscount);


// string input = "Pad this";
// // Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("01234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturns = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturns = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},\nAs a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N} shares at a return of {currentReturns:P2}.\n\nOur new product, Glorious Future offers a return of {newReturns:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n");
Console.WriteLine("Here's a quick comparision:\n");

string comparisonMessage = $"{currentProduct.PadRight(20)}{currentReturns:P2}   {currentProfit:C}\n{newProduct.PadRight(20)}{newReturns:P2}   {newProfit:C}";

Console.WriteLine(comparisonMessage);