using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri eklenmistir :" +musteri.AdSoyad);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Musteri silinmiştir :" + musteri.AdSoyad);
        }
       
    }
}
