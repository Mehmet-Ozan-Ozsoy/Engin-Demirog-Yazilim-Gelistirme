using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(ref Musteri[] musteriler)
        {
            Console.Write("YENİ MÜŞTERİ EKLE\n(Çıkış için '0'a, devam etmek için farklı herhangi bir tuşa basınız): ");
            char dongu = char.Parse(Console.ReadLine());

            while (dongu!='0')
            {
                int sayac = 0;
                Musteri musteri = new Musteri();
                Console.Write("Id\t\t: ");
                musteri.Id = int.Parse(Console.ReadLine());
                Console.Write("Ad\t\t: ");
                musteri.Ad = Console.ReadLine();
                Console.Write("Soyad\t\t: ");
                musteri.Soyad = Console.ReadLine();
                Console.Write("T.C. Kimlik No\t: ");
                musteri.TCKimlikNo = Console.ReadLine();
                Console.Write("Doğum Yılı\t: ");
                musteri.DogumYili = int.Parse(Console.ReadLine());
                Console.Write("Doğum Yeri\t: ");
                musteri.DogumYeri = Console.ReadLine();
                Console.Write("Cinsiyet\t: ");
                musteri.Cinsiyet = Console.ReadLine();
                Console.Write("Meslek\t\t: ");
                musteri.Meslek = Console.ReadLine();
                Console.Write("Adres\t\t: ");
                musteri.Adres = Console.ReadLine();
                Console.Write("E-Posta\t\t: ");
                musteri.EPosta = Console.ReadLine();
                Console.Write("Hesap Türü\t: ");
                musteri.HesapTuru = Console.ReadLine();
                Console.Write("Hesap No\t: ");
                musteri.HesapNo = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(musteri.Id+" Id numaralı müşteri başarıyla eklendi.\n");

                if (musteriler.Length == 0)
                {
                    Musteri[] geciciMusteriler = new Musteri[] { musteri };
                    musteriler = geciciMusteriler;
                }
                else
                {
                    for (int i = 0; i < sayac+1; i++)
                    {
                        Array.Resize(ref musteriler, musteriler.Length + 1);
                        musteriler[musteriler.GetUpperBound(0)] = musteri;
                    }
                }
                sayac ++;
                Console.Write("YENİ MÜŞTERİ EKLE\n(Çıkış için '0'a, devam etmek için farklı herhangi bir tuşa basınız): ");
                dongu = char.Parse(Console.ReadLine());
            }      
        }
        public void MusteriGoruntule(Musteri[] musteriler)
        {
            Console.Write("MÜŞTERİ GÖRÜNTÜLE\n(Çıkış için '0'a, devam etmek için farklı herhangi bir tuşa basınız): ");
            char devir = char.Parse(Console.ReadLine());

            while (devir!=0)
            {
                Console.Write("Lütfen görüntülemek istediğiniz müşterinin sıra numarasını giriniz.\nTüm müşterileri görüntülemek için '0' tuşuna basınız: ");
                int sira = int.Parse(Console.ReadLine());

                if (sira == 0)
                {
                    foreach (Musteri musteri in musteriler)
                    {
                        Console.WriteLine("MÜŞTERİ ID\t: " + musteri.Id + "\n____________________\nAd\t\t: " + musteri.Ad + "\nSoyad\t\t: " + musteri.Soyad + "\nT.C. Kimlik No\t: " + musteri.TCKimlikNo + "\nDoğum Yılı\t: " + musteri.DogumYili + "\nDoğum Yeri\t: " + musteri.DogumYeri + "\nCinsiyet\t: " + musteri.Cinsiyet + "\nMeslek\t\t: " + musteri.Meslek + "\nAdres\t\t: " + musteri.Adres + "\nE-Posta\t\t: " + musteri.EPosta + "\nHesap Türü\t: " + musteri.HesapTuru + "\nHesap No\t: " + musteri.HesapNo + "\n\n");
                    }
                }
                else if (sira > 0 && sira - 1 < musteriler.Length)
                {
                    Console.WriteLine("MÜŞTERİ ID\t: " + musteriler[sira - 1].Id + "\n____________________\nAd\t\t: " + musteriler[sira - 1].Ad + "\nSoyad\t\t: " + musteriler[sira - 1].Soyad + "\nT.C. Kimlik No\t: " + musteriler[sira - 1].TCKimlikNo + "\nDoğum Yılı\t: " + musteriler[sira - 1].DogumYili + "\nDoğum Yeri\t: " + musteriler[sira - 1].DogumYeri + "\nCinsiyet\t: " + musteriler[sira - 1].Cinsiyet + "\nMeslek\t\t: " + musteriler[sira - 1].Meslek + "\nAdres\t\t: " + musteriler[sira - 1].Adres + "\nE-Posta\t\t: " + musteriler[sira - 1].EPosta + "\nHesap Türü\t: " + musteriler[sira - 1].HesapTuru + "\nHesap No\t: " + musteriler[sira - 1].HesapNo + "\n\n");
                }
                else
                {
                    Console.WriteLine("Belirttiğiniz sıra numarasında kayıtlı müşteri bulunmamaktadır.");
                }
                Console.Write("MÜŞTERİ GÖRÜNTÜLE\n(Çıkış için '0'a, devam etmek için farklı herhangi bir tuşa basınız): ");
                devir = char.Parse(Console.ReadLine());
            }            
        }
    }
}