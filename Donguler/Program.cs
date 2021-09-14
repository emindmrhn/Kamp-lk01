using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //bu sekılde lısteleyemezsın cok uzar array = diziler 'de tanımla 
            //dinamik sistemler yaz

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java",
                "Python",
                "C++",
                "C#"};

            //asagısı hala dinamik degil kücüktür 3 falan yapmayacagız dinamik
            //yapmak icin kurslar.Lenght de kac eleman varsa onu soyler

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            //*dizi* temelli yapıları tek tek dönmeye yarar foreach
            //yani alltaki gibi de yazılabilir yogurt yeme seklı bu
            //foreach daha basıt ama
            //kursları dolas tek tek demek kurs takma isim

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }   
}   
