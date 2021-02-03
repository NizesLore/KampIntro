using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            //Burası ekran yani kredileri gösteren açılır kutu
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);

            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
            
            basvuruManager.BasvuruYap(new EsnafKrediManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};


            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
