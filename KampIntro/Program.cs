using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkenler
            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGiris = false;
            

            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            

            //şartlar
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
           

            if (sistemeGiris == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            

            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine("\n");


            //Ternary Operatörü  
            int yas1 = 27;
            string sonuc1 = yas1 < 25 ? "A" : "C";
            Console.WriteLine(sonuc1);

            int yas = 25;
            string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            Console.WriteLine(sonuc);

            //Switch
            var sembol = "Kartal";

            switch (sembol)
            {
                case "Kartal":
                    Console.WriteLine("BJK");
                    break;
                case "Kanarya":
                    Console.WriteLine("FB");
                    break;
                default:
                    Console.WriteLine("GS");
                    break;
            }

        }
    }
}
