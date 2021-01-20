using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteriler = new Musteri[] { };
            MusteriManager musteriEkle = new MusteriManager();
            MusteriManager musteriGoruntule = new MusteriManager();

            while (true)
            {
                Console.WriteLine("MÜŞTERİ KAYIT EKRANI\n____________________\n[1] Müşteri Ekle\n[2] Müşteri Görüntüle");
                Console.Write("Lütfen yapmak istediğiniz işleme ait numarayı tuşlayınız: ");
                char secim = char.Parse(Console.ReadLine());

                switch (secim)
                {
                    case '1': musteriEkle.MusteriEkle(ref musteriler); break;
                    case '2': musteriGoruntule.MusteriGoruntule(musteriler); break;
                    default: Console.WriteLine("Hatalı bir giriş yaptınız. Tekrar deneyiniz."); break;
                }
            }
            Console.ReadKey();
        }
    }
}