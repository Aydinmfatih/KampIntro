using Deneme2;

MyList<string> isimler = new MyList<string>();
isimler.Add("fatih");

Musteri musteri1 = new Musteri(2,"ahmet");

class Musteri
{
    public Musteri(int Id,string name)
    {
        Console.WriteLine(Id);
    }
    public void Ekle()
    {

    }
}


