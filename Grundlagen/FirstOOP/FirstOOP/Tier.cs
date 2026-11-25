using System;

public class Animal // Basisklasse für Tiere
{
    private string _name;
    private string _color;
    private DateTime _birthdate;

    public string Name // öffentlicher Getter für den Namen des Tieres
    {
        get
        {
            string myLocalVar = "myLocalVar";
            return _name;
        }
    }

    public DateTime Birthdate
    {
        get { return _birthdate; }
        set { _birthdate = value; }
    }

    public int Age
    {
        get
        {
            DateTime today = DateTime.Today;
            int age = today.Year - _birthdate.Year;
            return age;
        }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public Animal(string name, string color, DateTime birthdate) // Konstruktor
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name darf nicht leer sein.", nameof(name));

        if (string.IsNullOrWhiteSpace(color))
            throw new ArgumentException("Farbe darf nicht leer sein.", nameof(color));

        string myLocalVar = "myLocalVar";
        _name = name;
        _color = color;
        _birthdate = birthdate;
    }
    public Animal(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name darf nicht leer sein.", nameof(name));
        _name = name;
    }
    public virtual string MakeSound() // Überschreibt die Methode MakeSound() der Basisklasse
    {
        return "Animal Sound";
    }
    public virtual string MakeSound(int duration)
    {
        string result = "";
        for (int i = 0; i < duration; i++)
        {
            result += "Animal Sound\n";
        }
        return result;
    }
}