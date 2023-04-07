using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Ad = "Fatih";
musteri1.Soyad = "Aydın";

Musteri musteri2 = new Musteri();
musteri2.Ad = "kadir";
musteri2.Soyad = "Aydın";

Musteri musteri3 = new Musteri();
musteri3.Ad = "murat";
musteri3.Soyad = "Aydın";

MusteriManager musteriManager= new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Sil(musteri2);
musteriManager.Liste(musteri3);

Musteri[] musteri = new Musteri[] { musteri1, musteri2, musteri3 };
foreach (var item in musteri)
{
    Console.WriteLine(item.Ad);
}
for (int i = 0; i < musteri.Length; i++)
{
    Console.WriteLine(musteri[i].Ad + "" + musteri[i].Soyad);
}