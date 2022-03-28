
List<Radnik2> listaR = new();
List<Student2> listaS = new();

listaR.Add(new Radnik2 { _ime = "Pera", _prezime = "Peric", _plata = 20000 });
listaR.Add(new Radnik2 { _ime = "Asd", _prezime = "Qwe", _plata = 123 });

listaS.Add(new Student2 { _ime = "Pera", _prezime = "Peric", _brIndeksa = "213" });
listaS.Add(new Student2 { _ime = "Qwe", _prezime = "Zxc", _brIndeksa = "245" });

foreach(Radnik2 r in listaR)
{
    Console.WriteLine($"Ime radnika {r._ime}");
    Console.WriteLine($"Plata radnika {r._plata}");
}
foreach (Student2 s in listaS)
{
    Console.WriteLine($"Ime studenta {s._ime}");
    Console.WriteLine($"Indeks studenta: {s._brIndeksa}");
}
Console.WriteLine("--------------------------");
List<Osoba> osobe = new();

osobe.Add(new Student { _ime = "1111", _prezime = "1111", _brIndeksa = "213" });
osobe.Add(new Radnik { _ime = "asd", _prezime = "qwe", _plata = 123123 });
osobe.Add(new Student { _ime = "2222", _prezime = "3333", _brIndeksa = "213" });
osobe.Add(new Radnik { _ime = "zzzz", _prezime = "zzzz", _plata = 123123 });

foreach(Osoba o in osobe)
{
    o.PredstaviSe();
    if (o is Student s)
    {
        Console.WriteLine(s._brIndeksa);
    }else if (o is Radnik r)
    {
        Console.WriteLine(r._plata);
    }
}
public class Radnik2
{
    public string _ime;
    public string _prezime;
    public decimal _plata;
}
public class Student2 
{
    public string _ime;
    public string _prezime;
    public string _brIndeksa;
}



public abstract class Osoba
{
    public string _ime;
    public string _prezime;
    public abstract void PredstaviSe();
}

public class Radnik : Osoba
{
    public decimal _plata;
    public override void PredstaviSe()
    {
        Console.WriteLine($"Hej, ja sam radnik i zovem se {_ime} {_prezime} i plata mi je {_plata}");
    }
}

public class Student : Osoba
{
    public string _brIndeksa;
    public override void PredstaviSe()
    {
        Console.WriteLine($"Hej, ja sam student i zovem se {_ime} {_prezime} i indeks mi je {_brIndeksa}");
    }
}
