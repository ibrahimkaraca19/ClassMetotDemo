using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.ad = "Kamil";
            musteri1.soyad = "Öz";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.ad = "Aslı";
            musteri2.soyad = "Kara";

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.ad = "Yılmaz";
            musteri3.soyad = "Mesut";

            Musteri[] musteriler = new Musteri[]{ musteri1, musteri2, musteri3 };

            MusteriManager ekleCustomer = new MusteriManager();
            ekleCustomer.addCustomer(musteri1);
            ekleCustomer.addCustomer(musteri2);
            ekleCustomer.addCustomer(musteri3);

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.ad);
            }

            MusteriManager silCustomer = new MusteriManager();
            silCustomer.deleteCustomer(musteri1);
            silCustomer.deleteCustomer(musteri2);
            silCustomer.deleteCustomer(musteri3);
        }
    }
}
