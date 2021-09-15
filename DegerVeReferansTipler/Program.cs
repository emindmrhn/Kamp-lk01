using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? sayi1=sayi2 oldu
            //sayi1 in degeri sayi2 oldu
            //oyle kaldı
            //sayi2=65 demek sadece onun degeri degisti
            //yani sayi1 30 olarak kaldı
            //deger tipler steack

            int[] sayilar1 = new[] { 10, 20, 30 };
            int[] sayilar2 = new[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayilar1[0] ?? 999dur
            //sayilar1in referans nosu= sayilar2 nin referans
            //nosu gibi düsün yani 102 ise adresi 102 oluyor
            //deger tipte degeri atar
            //referans tipte adresi atar sayilar1 adresi 101 ise
            //sayilar 2nin adresi 102 ise
            //sayilar1=sayilar2 deyince sayilar1 in adresini 102 yapar

        }
    }
}
