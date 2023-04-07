using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklenmistir :" +musteri.Ad +" "+musteri.Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silinmiştir : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Musteri Listelenmiştir : " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
