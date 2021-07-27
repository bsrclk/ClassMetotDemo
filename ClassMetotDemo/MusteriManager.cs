using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Bilgileri ekleme=" +musteri.MusteriAdi+musteri.MusteriSoyadi+musteri.MusteriTel);
        }

        public void Listeleme(Musteri musteri)
        {
           Console.WriteLine( "Musteri Bilgileri Listeleme=" + musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.MusteriTel);
        }


        public void silme(Musteri musteri)
        {
            Console.WriteLine("Musteri Bilgileri silme=" + musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.MusteriTel);

        }










    }
}
