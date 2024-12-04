// call different kinds of methods in the .NET Class Library
Random dice = new Random(); // create instance of class Random()
int roll = dice.Next(1, 7); // call the Next() method on the dice object
Console.WriteLine(roll);