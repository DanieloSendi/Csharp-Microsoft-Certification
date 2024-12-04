// Overloaded methods
int number = 7;
string text = "Seven";

Console.WriteLine(number); // method uses a method signature that defines an int parameter.
Console.WriteLine(); // uses a method signature that defines zero parameters
Console.WriteLine(text); // uses a method signature that defines a string parameter

Random dice = new Random();
int roll1 = dice.Next(); // return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store
int roll2 = dice.Next(101); // expect a random value between 0 and 100
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
