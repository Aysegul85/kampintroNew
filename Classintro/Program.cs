using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string Adi = "Engin";
            int Yas = 36;
           
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Pyton";
            kurs1.KursEgitmeni = "Engin";
            kurs1.KursİzlenmeOrani = 68;
            


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Ayşe";
            kurs2.KursİzlenmeOrani = 76;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.KursEgitmeni = "Alican";
            kurs3.KursİzlenmeOrani = 34;


            /*Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.KursEgitmeni);
            }
            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.KursİzlenmeOrani);*/

            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.KursAdi +":" + kurs.KursEgitmeni+ ":" +kurs.KursİzlenmeOrani);
            }
  
            


        }



    }
    
}



    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int KursİzlenmeOrani { get; set; }

    }
    
