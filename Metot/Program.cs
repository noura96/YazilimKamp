using System;

namespace Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "elma", "karpuz" };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır elması";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type-safe
            foreach (Product x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("-------------------\n");

            }

            Console.WriteLine("-----------Metotlar------------\n");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle("Armut","Yeşil armut",12,8);
            sepetManager.Ekle("Elma", "Yeşil Elma", 10,9);
            sepetManager.Eklendi(urun1);
            sepetManager.Eklendi(urun2);
        }
    }
}

//Dont repeat your self (DRY) - Clean code - Best practice
