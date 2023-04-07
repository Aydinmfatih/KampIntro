using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("sonuç : " +toplam);
        }
        public void Topla2(string urunAdi,string aciklama,int fiyat)
        {
            Console.WriteLine("Ürün eklenmiştir :"+ urunAdi);
        }
    }
}
 