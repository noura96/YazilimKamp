using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1? 30

            int[] sayiler1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayiler1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]? 999

            //int,decimal,float,double,bool = değer tip
            //array,class,interface = referans tip

            //1.durum
            // stack           ----         heap
            // sayi1=10               
            // sayi2=30

            //2.durum
            // stack           ----         heap
            // sayi1=30               
            // sayi2=65

            //3.durum
            // stack                       ----                heap            
            // sayilar1 ---- adres Ör:101           new [10,20,30]       ---- adres Ör:101
            // sayilar2 ---- adres Ör:102           new [100,200,300]    ---- adres Ör:102

            //4.durum
            // stack                       ----                 heap            
            // sayilar1 ---- adres Ör:102           
            // sayilar2 ---- adres Ör:102           new [999,200,300]    ---- adres Ör:102

        }
    }
}
