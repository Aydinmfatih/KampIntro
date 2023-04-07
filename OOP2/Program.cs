using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.MusteriNo = "12345";
musteri1.Adi = "fatih";
musteri1.Soyadi= "12345";
musteri1.Id = 4;

TuzelMusteri musteri2= new TuzelMusteri();
musteri2.VergiNo= "12345"; ;
musteri2.Id = 3;

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();
MusteriManager musteriManager= new MusteriManager();
musteriManager.Add(musteri3);