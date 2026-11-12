class Animal { // Basisklasse für Tiere
    private _name: string;
    private _color: string;
    private _birthdate: Date;

    public get Name() {
        let myLocalVar = "myLocalVar";
        return this._name;
    } // öffentlicher Getter für den Namen des Tieres

    public makeSound() { // Methode, die den Laut des Tieres zurückgibt
        console.log("Animal sound");
    }

    public get Birthdate() { return this._birthdate; }
    public set Birthdate(value: Date) { this._birthdate = value; }

    public get Color() { return this._color; }
    public set Color(value: string) { this._color = value; }

    constructor(name: string, color: string, birthdate: Date) { // Konstruktur => "konstruiert" einen Studenten
        let myLocalVar = "myLocalVar";
        this._name = name;
        this._color = color;
        this._birthdate = birthdate;
    }
}

class Cow extends Animal { // Unterklasse von Animal
    public makeSound() { // Überschreibt!!! die Methode makeSound() der Basisklasse
        console.log("Moo");
    }
}

class Cat extends Animal { };

let myCow = new Cow("Bessie", "schwarz", new Date("2020-01-01")); // erstellt eine Instanz der Cow-Klasse
let myCow1 = new Cow("Molly", "braun", new Date("2020-02-01"));
let myCow2 = myCow;
let myCat = new Cat("Whiskers", "grau", new Date("2020-03-01"));
console.log(myCow == myCow2); // true, da myCow2 auf dasselbe Objekt verweist wie myCow
console.log(myCow2.Name);
myCow.Color = "weiß"; // ändert die Farbe der Cow
console.log(myCow2.Color);
console.log(myCow1.Color);
console.log(myCow1.Birthdate);
console.log(myCow1.makeSound());
console.log(myCat.Name);
console.log(myCat.Color);
console.log(myCat.Birthdate);
console.log(myCat.makeSound());