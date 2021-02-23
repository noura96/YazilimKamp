using System;
using System.Collections.Generic;
using System.Text;

namespace Metot
{
    class SepetManager
    {
        //syntax
        public void Ekle(string urunadi , string aciklama , double fiyat , int stokAdedi)
        {
            Console.WriteLine("Sepete ekle : " + urunadi );
        }
        public void Eklendi(Product urun)
        {
            Console.WriteLine("Tebrikleer...Sepete eklendi : " + urun.Adi );
        }
    }
}
