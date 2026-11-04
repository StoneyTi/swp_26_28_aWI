using FirstOOP;

Console.WriteLine("Hello, World!");
var myKuh = new Kuh("Paula", "Schwarz"); // instanziate a new Kuh object with name "Paula" and colour "Schwarz"

Console.WriteLine(myKuh.Name);
Console.WriteLine(myKuh.Colour);
Console.WriteLine(myKuh.GetErnaehrung());
Console.WriteLine(myKuh.GetLebensraum());
Console.WriteLine(myKuh.Gesundheit);
Console.ReadLine();