class Animal { // Basisklasse für Tiere
    private _name: string;
    private _color: string;
    private _birthdate: Date;

    public get Name() {
        let myLocalVar = "myLocalVar";
        return this._name;
    } // öffentlicher Getter für den Namen des Tieres

    public makeSound() { // Methode, die den Laut des Tieres zurückgibt
        return "Animal sound";
    }

    public get Birthdate() { return this._birthdate; }
    public set Birthdate(value: Date) { this._birthdate = value; }
    public get Age() {
        let today = new Date();
        let age = today.getFullYear() - this._birthdate.getFullYear();
        return age;
    }
    public get Color() { return this._color; }
    public set Color(value: string) { this._color = value; }

    constructor(name: string, color: string, birthdate: Date) { // Konstruktur => "konstruiert" einen Studenten
        let myLocalVar = "myLocalVar";
        this._name = name;
        this._color = color;
        this._birthdate = birthdate;
    }
}

