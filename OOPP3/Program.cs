using OOPP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
BasvuruManager krediManager = new BasvuruManager();
ILoggerService dataBaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
List<ILoggerService> loggerService = new List<ILoggerService>() { dataBaseLoggerService, fileLoggerService };
krediManager.BasvuruYap(konutKrediManager, loggerService);


List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
//krediManager.KrediOnBilgilendirmesiYap(krediler); 