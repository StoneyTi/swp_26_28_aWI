Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Hello World!");
Console.WriteLine("Write something creative! (exit to quit)");
Console.ForegroundColor = ConsoleColor.Red;
string userInput = Console.ReadLine();

// Reversing the input with the method Reverse() and cycle through it with ToArray()
Console.WriteLine(new string(userInput.Reverse().ToArray()));

while (userInput != "exit")
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nWrite something creative! (exit to quit)");
    Console.ForegroundColor = ConsoleColor.Red;
    userInput = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Green;

    if (userInput == "")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Please enter a value!");
        Console.ResetColor();
        continue;
    }
    else if (int.TryParse(userInput, out _))
    {
        Console.WriteLine("\nYou entered a number!");
    }
    else if (bool.TryParse(userInput, out _))
    {
        Console.WriteLine("\nYou entered a boolean value!");
    }
    else if (double.TryParse(userInput, out _))
    {
        Console.WriteLine("\nYou entered a double value!");
    }
    else
    {
        Console.WriteLine("\nYou entered a string value!");
    }
    Console.ResetColor();
}