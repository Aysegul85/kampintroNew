using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] meyveler = new string[] { }; //dizi array
              //Product[] Urunler = new Product[] {urun1, urun2, urun3};


             /* Product Urun1 = new Product();
              Urun1.Adi = "Elma";
              Urun1.Fiyati = 15;
              Urun1.Aciklama = "Amasya elması";

              Product Urun2 = new Product();
              Urun2.Aciklama = "Karpuz";
              Urun2.Fiyati = 80;
              Urun2.Aciklama = "Diyarbakır karpuzu";

              Product Urun3 = new Product();
              Urun3.Adi = "Kavun";
              Urun3.Fiyati = 35;
              Urun3.Aciklama = "Antalya kavunu";

              Product Urun4 = new Product();
              Urun4.Adi = "Portakal";
              Urun4.Fiyati = 12;
              Urun4.Aciklama = "Finike'nin turuncu bombası";

              Product[] Urunler = new Product[] { Urun1, Urun2, Urun3, Urun4 };
              foreach (var Urun in Urunler) //vardan sonraki Urun yerine herhangi bir şey yazılabilir alttaki Urun yeri de aynı şekilde değiştirilir.
              {
                  Console.WriteLine(Urun.Adi);
                  Console.WriteLine(Urun.Fiyati);
                  Console.WriteLine(Urun.Aciklama);
                  Console.WriteLine("..................");
              }


              Console.WriteLine(Urun4.Adi + " ve "+ Urun3.Adi+" "+"aldın abi. Allah bereket versin.");
              Console.WriteLine("Kırkağaç kavunu yoktu Antalya verdim. Afiyet bal şeker olsun abime.");

              Console.WriteLine("Ablam cennet hurması yok." +Urun4.Adi + " " + "verdim. De get işine.");


             Console.WriteLine("Ablama finike portakalı verdim. Afiyet olsun.");*/


            Productt Book1 = new Productt();
            Book1.Name = "Nietszche Ağladığında";
            Book1.Writer = "Irvin D. Yalom";
            Book1.Publisher = "Ayrıntı Yayınları";
            Book1.Price = 28.85;

            Productt Book2 = new Productt();
            Book2.Name = "Ruh Adam";
            Book2.Writer = "Hüseyin Nihal Atsız";
            Book2.Publisher = "Ötüken";
            Book2.Price = 17.80;

            Productt Book3 = new Productt();
            Book3.Name = "Zengin Baba Yoksul Baba";
            Book3.Writer = "Robert T. Kiyasoki";
            Book3.Publisher = "Alfa Yayınları";
            Book3.Price = 32;

            Productt Book4 = new Productt();
            Book4.Name = "Biz Hayır Diyoruz";
            Book4.Writer = "Eduardo Galeano";
            Book4.Publisher = "Metis Yayıncılık";
            Book4.Price = 27.60;

            Productt[] Books = new Productt[] { Book1, Book2, Book3, Book4 };
            foreach (var Book in Books)
            {
                Console.WriteLine(Book.Name);
                Console.WriteLine(Book.Writer);
                Console.WriteLine(Book.Publisher);
                Console.WriteLine(Book.Price);
                Console.WriteLine("....................");
            }


            Console.WriteLine("..........................Metotlar......................");
            //instance örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Book2);
            sepetManager.Ekle(Book2);

            sepetManager.Ekle2("Ruh Adam", "Hüseyin Nihal Atsız", "Ötüken", 17.80);




        }
    }
}












        
    

