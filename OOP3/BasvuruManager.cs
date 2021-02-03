using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService>loggerServices)
        {
            //Başvuran bilgilerini değerlendirme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Buraya KonutKrediManager dersen tüm başvuruları konut kredisine bağımlı hale getirirsin..

            krediManager.Hesapla();
            //Bu ifade sayesinde hangi krediyi gönderirsem onun Hesapla sı çalışır.
            // loggerService.Log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }

    }

}


