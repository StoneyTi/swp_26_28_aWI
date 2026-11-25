using FirstOOP;

Cow myCow = new Cow("Bessie", "schwarz", new DateTime(2020, 1, 1)); // erstellt eine Instanz der Cow-Klasse
Cow myCow1 = new Cow("Molly", "braun", new DateTime(2020, 2, 1));
Cow myCow2 = myCow;
Cat myCat = new Cat("Whiskers", "grau", new DateTime(2020, 3, 1));

Console.WriteLine(myCow == myCow2); // True, da myCow2 auf dasselbe Objekt verweist wie myCow
Console.WriteLine(myCow2.Name);
myCow.Color = "weiß"; // ändert die Farbe der Cow
Console.WriteLine(myCow2.Color);
Console.WriteLine(myCow1.Color);
Console.WriteLine(myCow1.Birthdate);
Console.WriteLine(myCow1.MakeSound());
Console.WriteLine(myCat.Name);
Console.WriteLine(myCat.Color);
Console.WriteLine(myCat.Birthdate);
Console.WriteLine(myCat.MakeSound());
Console.WriteLine(myCow.Age);
Console.WriteLine(myCat.MakeSound(100));

var myAnimals = new List<Animal>();
myAnimals.Add(myCow);
myAnimals.Add(myCow1);
myAnimals.Add(myCat);

Console.WriteLine(myAnimals);

