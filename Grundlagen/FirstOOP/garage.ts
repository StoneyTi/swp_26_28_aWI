interface IVerkaufsartikel {
    verkaufsNamen: string;
    preis: number;
}

class Fahrzeug implements IVerkaufsartikel {
    private fahrzeugtyp: string;
    private name: string;
    verkaufsNamen: string;
    preis: number;

    get Fahrzeugtyp(): string { return this.fahrzeugtyp; }
    get Name(): string { return this.name; }

    constructor(fahrzeugtyp: string, name: string, preis: number) {
        this.fahrzeugtyp = fahrzeugtyp;
        this.name = name;
        this.verkaufsNamen = `${fahrzeugtyp} ${name}`;
        this.preis = preis;
    }
}

class Fahrrad extends Fahrzeug {
    private anzahlGaenge: number;
    get AnzahlGaenge(): number { return this.anzahlGaenge; }

    constructor(fahrzeugtyp: string, name: string, anzahlGaenge: number) {
        super(fahrzeugtyp, name, 500);
        this.anzahlGaenge = anzahlGaenge;
    }
}

class Auto extends Fahrzeug {
    private anzahlTueren: number;
    get AnzahlTueren(): number { return this.anzahlTueren; }

    constructor(fahrzeugtyp: string, name: string, anzahlTueren: number, preis: number) {
        super(fahrzeugtyp, name, preis);
        this.anzahlTueren = anzahlTueren;
    }
}

class PKW extends Auto {
    private motorTyp: string;
    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("PKW", name, anzahlTueren, 30000);
        this.motorTyp = motorTyp;
    }
}

class LKW extends Auto {
    private motorTyp: string;
    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("LKW", name, anzahlTueren, 50000);
        this.motorTyp = motorTyp;
    }
}

class Reifen implements IVerkaufsartikel {
    verkaufsNamen: string;
    preis: number;
    marke: string;
    groesse: number;
    typ: string;
    constructor(marke: string, groesse: number, typ: string) {
        this.marke = marke;
        this.groesse = groesse;
        this.typ = typ;
        this.verkaufsNamen = `${this.marke} ${this.typ}`;
        this.preis = 100;
    }
}

class Garage {
    private fahrzeuge: Fahrzeug[] = [];
    private reifen: Reifen[] = [];

    public addFahrzeug(fahrzeug: Fahrzeug): void {
        this.fahrzeuge.push(fahrzeug);
    }

    public addReifen(reifen: Reifen): void {
        this.reifen.push(reifen);
    }

    public anzahlFahrzeuge(): number {
        return this.fahrzeuge.length;
    }

    public anzahlVerkaufbareArtikel(): number {
        return this.fahrzeuge.length + this.reifen.length;
    }

    get anzahlAutos(): number {
        let anzahlAutos: number = 0;
        for (const fahrzeug of this.fahrzeuge) {
            if (fahrzeug instanceof Auto) {
                anzahlAutos++;
            }
        }
        return anzahlAutos;
    }
}

// Verwendung
var myGarage = new Garage();
myGarage.addFahrzeug(new PKW("BMW", 4, "Benzin"));
myGarage.addFahrzeug(new PKW("BMW", 2, "Benzin"));
myGarage.addFahrzeug(new LKW("MAN", 2, "Diesel"));
myGarage.addFahrzeug(new Fahrrad("Fahrrad", "Mountainbike", 21));
myGarage.addReifen(new Reifen("Michelin", 16, "Sommerreifen"));
myGarage.addReifen(new Reifen("Continental", 17, "Winterreifen"));

console.log(`Anzahl Fahrzeuge in der Garage: ${myGarage.anzahlFahrzeuge()} davon Autos: ${myGarage.anzahlAutos}`);
console.log(`Anzahl Verkaufbare Artikel in der Garage: ${myGarage.anzahlVerkaufbareArtikel()}`);