using System.Xml;

struct Koordinataoar
{
    public Koordinataoar(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float X { get; set; }
    public float Y { get; set; }
}

struct EmberStruct
{
    public string Nev { get; set; }
    public int kor { get; set; }
}

class EmberClass
{
    public string Nev { get; set; }
    public int kor { get; set; }
}

class Program
{
    static void Main()
    {
        //Akkor ajánlott
        //logikailag nem megkötött adat struktúra
        //több féle típust enged meg
        //több végtelen mennyiségü adat típust lehet megadni

        (float x, float y) koordinatak = (25.5F, .15F); //ez ugyanaz mint a struktúra
        //Elérése változóneve.itemneve vagy valtozóneve.Itemsorszám
        //Ha van értelme egyenként az adatoknak

        (float, float) koordinatakk = (25.5F, .15F);
        //Ha nincs értelme egyenként az adatoknak
        //Elérése valtozóneve.Itemsorszám koordinatakk.Itemsorszám

        // fv több értékkel térhet vissza tuple használatával



        // reference type
        int x = 10;
        int y = x;

        y -= 5;

        Console.WriteLine($"{x}");
        Console.WriteLine($"{y}");



        // value reference type
        // együtt változik a 2
        int[] t1 = { 10, };
        int[] t2 = t1;
        t2[0] -= 5;

        Console.WriteLine($"{t1[0]}");
        Console.WriteLine($"{t2[0]}");

        // struct -> VALUE
        // class -> REF

        // privát konstruktort nem lehet készíteni
        // mert akkor is lesz nyilvános belőle

        // classba nem mehet class
        // structba mehet class

        EmberClass ec = new()
        {
            Nev = "Bela",
            kor = 13,
        };

        EmberStruct es = new()
        {
            Nev = "Bela",
            kor = 13,
        };

        List<EmberClass> emberClassList = new();
        // class listánál a belerakott adatok módusulásnál az eredetit is módosítja
        emberClassList.Add(ec);
        // csak egy refereniát ad hozzá

        List<EmberStruct> emberStructList = new();
        emberStructList.Add(es);
        // érték másolás történt

        emberClassList[0].Nev = "Elizabett";
        Console.WriteLine(ec.Nev);

        es.Nev = "Elizabett";
        Console.WriteLine(emberStructList[0].Nev);


        int szam = int.Parse(Console.ReadLine()!);  // tudom hogy lehet null értéke jel: ! jel

        string? valami = Console.ReadLine();  // lehet null az értéke (string esetén amúgy is) jel: ? jel

        int? sz = null;  // megengedi a null-t
        // int z = null!;  // nem engedi meg a null-t és úgy sem hogy !-jel van ott, mivel úgy lett létrehozva hogy nem engedheti meg a null-t

        // c# c++ vb ->
        // Common language interface ->
        // gépi kód
        // csak akkor lehet ha azonos a framework


    }
}
