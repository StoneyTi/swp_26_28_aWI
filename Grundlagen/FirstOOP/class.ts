class Kuh {
    private _color: string = "";
    private _name: string = "";

    public get Name(): string {
        let myLocalVar = "myLocalVar";
        return this._name;
    }
    public get Color() { return this._color; }
    public set Color(value: string) { this._color = value; }

    constructor(name: string, color: string) { // Konstruktur => "konstruiert" einen Studenten
        let myLocalVar = "myLocalVar";
        this._name = name;
        this._color = color;
    }
}

let myKuh = new Kuh("Bessie", "schwarz"); // erstellt eine Instanz der Kuh-Klasse
let myKuh1 = new Kuh("Molly", "braun");
let myKuh2 = myKuh
console.log(myKuh == myKuh2); // true, da myKuh2 auf dasselbe Objekt verweist wie myKuh
console.log(myKuh2.Name);
myKuh.Color = "weiß"; // ändert die Farbe der Kuh
console.log(myKuh2.Color);