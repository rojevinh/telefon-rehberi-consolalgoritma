using System;
using System.Collections.Generic;

// Kişi bilgilerini tutmak için basit bir yapı
struct Kisi
{
    public string Ad;
    public string Soyad;
    public string TelefonNumarasi;
}

class Program
{
    static List<Kisi> kisiler = new List<Kisi>(); // Rehberdeki kişileri saklamak için bir liste

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nSeçiminiz:");
            Console.WriteLine("1. Kişi Ekle");
            Console.WriteLine("2. Rehber Yazdır");
            Console.WriteLine("3. Çıkış");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Write("Ad: ");
                    string ad = Console.ReadLine();
                    Console.Write("Soyad: ");
                    string soyad = Console.ReadLine();
                    Console.Write("Telefon Numarası: ");
                    string telefonNumarasi = Console.ReadLine();

                    kisiler.Add(new Kisi { Ad = ad, Soyad = soyad, TelefonNumarasi = telefonNumarasi });
                    Console.WriteLine("{0} {1} başarıyla eklendi!", ad, soyad);
                    break;
                case 2:
                    if (kisiler.Count == 0)
                    {
                        Console.WriteLine("Rehberde kayıtlı kişi bulunamadı.");
                    }
                    else
                    {
                        Console.WriteLine("---------- Rehber ----------");
                        foreach (Kisi kisi in kisiler)
                        {
                            Console.WriteLine("{0} {1} - {2}", kisi.Ad, kisi.Soyad, kisi.TelefonNumarasi);
                        }
                    }
                    break;
                case 3:
                    Environment.Exit(0); // Uygulamadan çıkış
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
