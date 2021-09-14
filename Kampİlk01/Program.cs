using System;

namespace Kampİlk01
{
    class Program
    {
        private const double V = 5.50;

        static void Main(string[] args)
        {
            //veriler degiskenlerde tutulur
            //string metinsel veri veritürü 
            //metinsel "a" , sayısal '2'
            //type safety - tip güvenliği
            //değer tututcu, alias
            //int tam sayılar 
            //double ondalıklı sayılar
            //boolean javada, bool c# sisteme giriş yapmış mı vs şart

            string kategoriEtiketi = "Kategoriler";
            int adaySayisi = 27000;
            double faizOranı = 3.50;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 5.40;
            double dolarBugun = 5.40;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            //bool true false olması ornek, veri kaynagindan geliyor
            //sart gecerliyse { } kod calissin
            // iki kere taba bas if 
            //if calısmassa else calısır eğer/degilse gibi
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);            
        }
    }
}
