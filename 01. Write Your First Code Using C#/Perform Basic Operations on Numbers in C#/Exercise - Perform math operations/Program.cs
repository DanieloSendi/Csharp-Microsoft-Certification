int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//decimal decimalQuotient = 7.0m / 5;
//decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient = 7.0m / 5.0m;

Console.WriteLine($"Decimal quotient: {decimalQuotient}");

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;

Console.WriteLine(value1);
Console.WriteLine(value2);