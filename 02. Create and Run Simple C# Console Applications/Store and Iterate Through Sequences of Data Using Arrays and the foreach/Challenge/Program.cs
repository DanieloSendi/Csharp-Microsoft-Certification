// Challenge activity for nested iteration and selection statements
// Report the Order IDs that need further investigation

// Declare an array and initialize it to contain values represent the fraudulent Order ID data that your application use

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string id in orderIDs)
{
    if (id.StartsWith("B"))
        {
        Console.WriteLine(id);
    }
}
 