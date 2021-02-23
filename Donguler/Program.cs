using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //donguler
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            

            //array-dizi

            string[] kurslar = new string[] { "YGYK", "PBTK", "Java", "Python", "C++", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\nSayfa Sonu\n");
            

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\n");

            //While
            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x+=2;
            }

        }
    }
}
