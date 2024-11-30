/*
string firstName = "Bob";
string greeting = "Hello";

string message = $"{greeting} {firstName}!";

// use string interpolation to combine a literal string and a variable value
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);
*/

// use string interpolation with multiple variables and literal strings
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

// avoid intermediate variables
Console.WriteLine($"{updateText} {version}!");

// combine verbatim literals and string interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
