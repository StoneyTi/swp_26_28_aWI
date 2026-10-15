using System.Diagnostics;
using System.Numerics;

bool isnumber = false;
string? userInput = null;

string GetInputType(string input)
{
    if (int.TryParse(input, out _))
    {
        isnumber = true;
        return "a number";
    }

    if (bool.TryParse(input, out _))
    {
        return "a boolean value";
    }

    if (double.TryParse(input, out _))
    {
        isnumber = true;
        return "a double value";
    }

    return "a string value";
}

while (true)
{
    isnumber = false;

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Write something creative! (exit to quit)");
    Console.ForegroundColor = ConsoleColor.Red;

    userInput = Console.ReadLine();

    if (userInput == "exit")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Please enter a valid value!");
        Console.ResetColor();
        continue;
    }

    Console.WriteLine(new string(userInput.Reverse().ToArray()));

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nYou entered {GetInputType(userInput)}!");

    if (isnumber)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nplease select a math operation 1-3");
        Console.WriteLine("1. Square\n2. Square Root\n3. Factorial");

        int? mathOp = int.Parse(Console.ReadLine());

        var sw = Stopwatch.StartNew();
        string output = getMathOp(mathOp, userInput);
        Console.WriteLine(output);
        sw.Stop();

        Console.WriteLine($"(total: {sw.Elapsed.TotalMilliseconds:F3} ms)");

    }
}

string getMathOp(int? OpSelect, string? userInput)
{
    switch (OpSelect)
    {
        case 1:
            return $"\nthe square of {userInput} is {Square.Calculate(double.Parse(userInput))}\n";
        case 2:
            return $"\nthe square root of {userInput} is {Math.Sqrt(double.Parse(userInput))}\n";
        case 3:
            var result = Factorial.Calculate(int.Parse(userInput!));
            if (result == null)
                return "\ninvalid input: factorial is not defined for negative numbers.\n";
            return $"\nthe factorial of {userInput} is {result}\n";
        default:
            return "\ninvalid selection. Please choose 1, 2, or 3.\n";
    }
}
    public class Factorial
    {
        public static BigInteger? Calculate(int n)
        {
            if (n < 0) return null;

            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

    class Square
    {
        public static double Calculate(double n)
        {
            return n * n;
        }
    }