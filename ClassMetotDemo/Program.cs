using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "ada";
            musteri1.MusteriSoyadi = "çolak";
            musteri1.MusteriTel = 054155696;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "arda";
            musteri2.MusteriSoyadi = "çolak";
            musteri2.MusteriTel = 0541585696;

            Musteri[] musteri = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine(musteriler.MusteriAdi);
                Console.WriteLine(musteriler.MusteriSoyadi);
                Console.WriteLine(musteriler.MusteriTel);

            }

            Console.WriteLine("******************************");

            MusteriManager musteriManager = new MusteriManager();

           
            
            musteriManager.Ekle(musteri1);
            musteriManager.Listeleme(musteri);
            musteriManager.silme(musteri2);
           
           














        }
    }
}
