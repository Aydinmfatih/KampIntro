using deneme3;

IKrediManager ihtiyacKrediManager= new IhtiyacKrediManager();

IKrediManager konutKrediManager = new KonutKrediManager();

IKrediManager tasitKrediManager = new TasıtKrediManager();


BasvuruManager basvuruManager= new BasvuruManager();

   
List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager};
basvuruManager.KrediOnBilgilendirmesiYap(krediler);
basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService>(){ new DatabaseLoggerService(), new FileLoggerService()});
basvuruManager.BasvuruYap(tasitKrediManager,new List<ILoggerService>() { new SmsLoggerService()});