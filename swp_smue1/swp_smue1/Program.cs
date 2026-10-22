using System.Numerics;

Console.WriteLine("Geben Sie bitte eine ganze Zahl oder eine Zeichenkette ein:");
string UserInput = Console.ReadLine();

if (int.TryParse(UserInput, out _))
{
    Console.WriteLine("Sie haben eine ganze Zahl eingegeben, welche mathematische Operation möchten Sie darauf ausführen?");
    Console.WriteLine("1) Addition\n2) Multiplikation\n3) Division\n4) Fakultät\n5) Wurzelziehen");
    int mathOp = int.Parse(Console.ReadLine());
    Console.WriteLine(getMathOp(mathOp, UserInput));
}
else
{
    Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
    Console.WriteLine("1) Alle Selbstlaute entfernen\n2) Die Zeichenkette umdrehen\n3) Die Anzahl an Zeichen ausgeben");
    int stringOp = int.Parse(Console.ReadLine());
    Console.WriteLine(getStringOp(stringOp, UserInput));
}

string getMathOp(int? OpSelect, string userInput)
{
    int number = int.Parse(userInput);

    switch (OpSelect)
    {
        case 1:
            Console.WriteLine("Bitte geben Sie eine zweite Zahl ein.");
            int num2 = int.Parse(Console.ReadLine());
            return $"\nDas Ergebnis der Addition ist {number + num2}\n";
        case 2:
            Console.WriteLine("Bitte geben Sie eine zweite Zahl ein.");
            num2 = int.Parse(Console.ReadLine());
            return $"\nDas Ergebnis der Multiplikation ist {number * num2}\n";
        case 3:
            Console.WriteLine("Bitte geben Sie eine zweite Zahl ein.");
            num2 = int.Parse(Console.ReadLine());
            if (num2 == 0) return "\nDivision durch 0 ist nicht möglich.\n";
            return $"\nDas Ergebnis der Division ist {number / num2}\n";
        case 4:
            return $"\nDas Ergebnis der Fakultät ist {Factorial.Calculate(number)}\n";
        case 5:
            return $"\nDas Ergebnis der Wurzel ist {Math.Sqrt(number)}\n";
        default:
            return "\nUngültige Auswahl.\n";
    }
}

string getStringOp(int? OpSelect, string userInput)
{
    switch (OpSelect)
    {
        case 1:
            string selbstlaute = "aeiouäöüAEIOUÄÖÜ";
            string ohneSelbstlaute = "";

            foreach (char zeichen in userInput)
            {
                if (!selbstlaute.Contains(zeichen))
                {
                    ohneSelbstlaute += zeichen;
                }
            }

            return $"\nOhne Selbstlaute: {ohneSelbstlaute}\n";
        case 2:
            return $"\nUmgedreht: {new string(userInput.Reverse().ToArray())}\n";
        case 3:
            return $"\nDie Zeichenkette hat {userInput.Length} Zeichen.\n";
        default:
            return "\nUngültige Auswahl.\n";
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