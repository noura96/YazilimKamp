using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassIntro
            Kurss kurs1 = new Kurss();
            kurs1.kursAdi = "C#";
            kurs1.Eğitmen = "Engin";
            kurs1.izlenmeOrani = 86;

            Kurss kurs2 = new Kurss();
            kurs2.kursAdi = "Java";
            kurs2.Eğitmen = "Ahmet";
            kurs2.izlenmeOrani = 60;

            Kurss kurs3 = new Kurss();
            kurs3.kursAdi = "Python";
            kurs3.Eğitmen = "Berker";
            kurs3.izlenmeOrani = 34;

            Console.WriteLine(kurs1.kursAdi + " " + kurs1.Eğitmen + "\n");

            Kurss[] kurslar1 = new Kurss[] { kurs1, kurs2, kurs3 };

            foreach (var kursx in kurslar1)
            {
                Console.WriteLine(kursx.kursAdi + " : " + kursx.Eğitmen);
            }
            //var bütün veri tipler için(Kurss/String.. yazılabilir)
        }
    }
    //ClassIntro
    class Kurss
    {
        public string kursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
    
}

//byte : Uzunluğu 1 byte’tır, 0 ile 255 arasında değer alır.

//sbyte : Uzunluğu 1 byte’tır, -128 ile 127 arasında değer alır.

//short : Uzunluğu 2 byte’tır, -32768 ile 32767 arasında değer alır.

//ushort : Uzunlupu 2 byte’tır, 0 ile 65535 arasında değer alır.

//int : Uzunluğu 4 byte’tır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.

//uint : Uzunluğu 4 byte’tır, 0 ile 4.294.967.295 arasında değer alır.

//long : Uzunluğu 8 byte’tır, -1020 ile 1020 arasında değer alır.

//ulong : Uzunluğu 8 byte’tır, 0 ile 2 x 1020 arasında değer alır.

//float : Uzunluğu 4 byte’tır, 1.5 x 10 - 45 ile 3.4 x 1038 arasında değer alır.

//double : Uzunluğu 8 byte’tır, 5.0 x 10 - 324 ile 1.7 x 10308 arasında değer alır.

//decimal : Uzunluğu 12 byte’tır, ±1.0 x 10 - 28 ile ±7.9 x 1028 arasında değer alır.

//char : Uzunluğu 2 byte’tır, Bütün ınicode karakterleri kapsar.

//string : Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır.

//boolean : True – false değer tutan tiptir
