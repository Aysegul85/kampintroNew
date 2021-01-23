using System;

namespace kampintroNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            string kurs1 = "Program Geliştirici Kursu";
            string kurs2 = "Programlamaya Başlangıç Kursu";
            string kurs3 = "Java";
            string kurs4 = "Pyton";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            
            //array dizi
            string[] Kurslar = new string[] { "Program Geliştirici Kursu", "Programlamaya Başlangıç Kursu", "Java", "Pyton" };


            for (int i = 0; i < Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }



          

            /*
              public string KursAdi { get; set; }
              public string Egitmeni { get; set; }
              public int İzlenmeOrani { get; set; }

              */













        }
    }
}
