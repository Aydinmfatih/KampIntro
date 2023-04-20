using Deneme;

Musteri musteri1= new Musteri();
musteri1.Id = 1;
musteri1.AdSoyad = "fatih aydın";
musteri1.MusteriTc = "1234567890";


Musteri musteri2 = new Musteri();
musteri2.Id = 1;
musteri2.AdSoyad = "ahmet aydın";
musteri2.MusteriTc = "1234567890";

Musteri musteri3 = new Musteri();
musteri3.Id = 1;
musteri3.AdSoyad = "eren";
musteri3.MusteriTc = "1234567890";

MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteri1);
musteriManager.Delete(musteri2);

Musteri[] musteri = new Musteri[] { musteri1, musteri2,musteri3 };
foreach (var item in musteri)
{
    Console.WriteLine("Musteriler Listelenmistir :"+ item.AdSoyad);
}
for (int i = 0; i < musteri.Length; i++)
{
    Console.WriteLine(musteri[i].AdSoyad);
}