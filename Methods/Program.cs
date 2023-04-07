using Methods;

Product product1 = new Product();
product1.Adi = "elma";
product1.Aciklama = "yeşil elma";
product1.Fiyati = 25;

Product product2 = new Product();
product2.Adi = "karpuz";
product2.Aciklama = "diyarbakır karpuzu";
product2.Fiyati = 80;

Product[] products = new Product[] { product1, product2 };
foreach (var item in products)
{
    Console.WriteLine(item.Adi);
}

SepetManager sepetManager = new SepetManager();
sepetManager.Add(product1);
sepetManager.Add(product2);
