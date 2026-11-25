using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Cow : Animal // Unterklasse von Animal
    {
        public Cow(string name, string color, DateTime birthdate)
            : base(name, color, birthdate) { }

        public string MakeSound() // Überschreibt die Methode MakeSound() der Basisklasse
        {
            return "Moo";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, string color, DateTime birthdate)
            : base(name, color, birthdate) { }

        public override string MakeSound()
        {
            return "Meow";
        }

        public override string MakeSound(int duration)
        {
            string result = "";
            for (int i = 0; i < duration; i++)
            {
                result += "Meow\n";
            }
            return result;
        }
    }
}