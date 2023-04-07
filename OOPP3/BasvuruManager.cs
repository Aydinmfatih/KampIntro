using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            foreach (var log in loggerService)
            {
                log.Log();
            }
        }
        
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }

        internal void BasvuruYap(IKrediManager konutKrediManager, ILoggerService dataBaseLoggerService)
        {
            throw new NotImplementedException();
        }
    }
}
