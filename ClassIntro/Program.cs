using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Emin";
            int yas = 19;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Emin";
            kurs1.İzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Demirhan";
            kurs2.İzlenmeOrani = 15;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Mücahit";
            kurs3.İzlenmeOrani = 90;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursEgitmeni = "Selim";
            kurs4.İzlenmeOrani = 95;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };
            
            //kurs takma ismi

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmeni);
            }

            Egitmenler egitmen1 = new Egitmenler();
            egitmen1.EgitmenAdi = "Emin Demirhan";
            egitmen1.EgitmenYaşi = 19;
            egitmen1.EgitmenBasariOrani = 75.5;

            Egitmenler egitmen2 = new Egitmenler();
            egitmen2.EgitmenAdi = "Mücahit Selim";
            egitmen2.EgitmenYaşi = 28;
            egitmen2.EgitmenBasariOrani = 98.5;



            Egitmenler[] egitmen = new Egitmenler[] { egitmen1, egitmen2 };

            foreach (var egitmenler in egitmen)
            {
                Console.WriteLine("Eğitmen İsmi" + ":" + egitmenler.EgitmenAdi +" "+ "Yaşı" +":"+ egitmenler.EgitmenYaşi + " " +"  "+ Başarı Oranı=" + egitmenler.EgitmenBasariOrani);

            }


           // Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int İzlenmeOrani { get; set; }
    } 

    class Egitmenler

    {
        public string EgitmenAdi { get; set; }
        public int EgitmenYaşi { get; set; }
        public double EgitmenBasariOrani { get; set; }
    }
}
