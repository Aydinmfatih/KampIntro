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
       public void Topla2(string urunAdi,string egitim ,int sayi)
        {
            Console.WriteLine(urunAdi +" "+ egitim +" "+ sayi);
        }
        public void Topla3(int sayi1, int sayi2)
   
        {
            int toplam2;
            toplam2= sayi1 + sayi2;
            Console.WriteLine(toplam2);
        }
    }
}
 