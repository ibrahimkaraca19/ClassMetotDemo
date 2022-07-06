using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void addCustomer(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + " " + musteri.soyad + " isimli müşteri eklendi");
        }

        public void deleteCustomer(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + " " + musteri.soyad + " isimli müşteri silindi");
        }
    }
}
