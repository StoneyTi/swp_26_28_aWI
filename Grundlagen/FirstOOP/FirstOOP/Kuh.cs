using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Kuh
    {
        string _name; // private field for the name of the Kuh
        string _colour; // private field for the colour of the Kuh

        public string Name // public property for the name of the Kuh
        {
            get { return _name; } // getter for the name
            set { _name = value; } // setter for the name
        }

        public string Colour // public property for the colour of the Kuh
        {
            get { return _colour; } // getter for the colour
            set { _colour = value; } // setter for the colour
        }

        // Constructor for the Kuh class
        public Kuh(string name, string colour) // impliziert Rückgabewert 
        {
            if (string.IsNullOrEmpty(name)) // check if name is null or empty
            {
                throw new ArgumentException("Name cannot be null or empty"); // throw exception if name is null or empty
            }
            if (string.IsNullOrEmpty(colour)) // check if colour is null or empty
            {
                throw new ArgumentException("Colour cannot be null or empty"); // throw exception if colour is null or empty
            }
            _name = name;
            _colour = colour;
        }
    }
}