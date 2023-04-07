

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C# kursu";
kurs1.Egitmeni = "Engin demrog ";
kurs1.BasariOrani = 6;


Kurs kurs2 = new Kurs();
kurs2.KursAdi = "C kursu";
kurs2.Egitmeni = "Engin ";
kurs2.BasariOrani = 67;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "javakursu";
kurs3.Egitmeni = "Engin ";
kurs3.BasariOrani = 7;

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

foreach (var kurs in kurslar)

{
    Console.WriteLine(kurs.KursAdi +" "+ kurs.Egitmeni + "" +kurs.BasariOrani );
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int BasariOrani { get; set; }
}