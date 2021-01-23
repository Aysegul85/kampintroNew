using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        //naming convention isimlendirme kuralı
        //syntax yazım şekli. Metotların yazım şekli public void ekle

        public void Ekle(Productt Book)
        {
            Console.WriteLine("Sepete eklendi" + Book);
        }


        public void Ekle2(string BookName, string BookWriter, string BookPublisher, double BookPrize)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + BookName);
        }


    }
}
