string GetInputType(string input)
{
    if (int.TryParse(input, out _))
    {
        return "a number";
    }

    if (bool.TryParse(input, out _))
    {
        return "a boolean value";
    }

    if (double.TryParse(input, out _))
    {
        return "a double value";
    }

    return "a string value";
}

while (true)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Write something creative! (exit to quit)");
    Console.ForegroundColor = ConsoleColor.Red;

    string? userInput = Console.ReadLine();

    if (userInput == "exit")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Please enter valid a value!");
        Console.ResetColor();
        continue;
    }

    Console.WriteLine(new string(userInput.Reverse().ToArray()));

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nYou entered {GetInputType(userInput)}!");
}