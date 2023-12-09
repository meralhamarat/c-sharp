using System;
using System.Collections.Generic;

class FutbolOyuncusu
{
    public string Ad { get; set; }
    public string Takim { get; set; }
    public string Pozisyon { get; set; }
    public int Hiz { get; set; }
    public int Dayaniklilik { get; set; }

    public FutbolOyuncusu(string ad, string takim, string pozisyon, int hiz, int dayaniklilik)
    {
        Ad = ad;
        Takim = takim;
        Pozisyon = pozisyon;
        Hiz = hiz;
        Dayaniklilik = dayaniklilik;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("********** Futbolcu Kartı **********");
        Console.WriteLine("************************************");
        Console.WriteLine($"Oyuncu Adı: {Ad}");
        Console.WriteLine($"Takım: {Takim}");
        Console.WriteLine($"Pozisyon: {Pozisyon}");
        Console.WriteLine($"Hız: {Hiz}");
        Console.WriteLine($"Dayanıklılık: {Dayaniklilik}");
        Console.WriteLine("************************************\n");
    }
}

class FutbolKartiOyunu
{
    static void Main()
    {
        List<FutbolOyuncusu> futbolcular = new List<FutbolOyuncusu>
        {
            new FutbolOyuncusu("Lionel Messi", "Paris Saint-Germain", "Forvet", 90, 80),
            new FutbolOyuncusu("Cristiano Ronaldo", "Manchester United", "Forvet", 88, 85),
            new FutbolOyuncusu("Neymar", "Paris Saint-Germain", "Forvet", 92, 75),
            new FutbolOyuncusu("Sergio Ramos", "Paris Saint-Germain", "Defans", 78, 88),
            new FutbolOyuncusu("Kevin De Bruyne", "Manchester City", "Orta Saha", 86, 82),
            new FutbolOyuncusu("Mohamed Salah", "Liverpool", "Forvet", 87, 79),
            new FutbolOyuncusu("Arda Turan", "Galatasaray", "Orta Saha", 85, 75),
            new FutbolOyuncusu("Burak Yılmaz", "Beşiktaş", "Forvet", 82, 77),
            new FutbolOyuncusu("Hakan Çalhanoğlu", "AC Milan", "Orta Saha", 84, 78),
            new FutbolOyuncusu("Merih Demiral", "Atalanta", "Defans", 80, 85),
            new FutbolOyuncusu("Ozan Tufan", "Fenerbahçe", "Orta Saha", 79, 81),
            new FutbolOyuncusu("Çağlar Söyüncü", "Leicester City", "Defans", 81, 83)
        };

        Console.WriteLine("Futbol Kartı Oyununa Hoş Geldiniz!");

        while (true)
        {
            Console.WriteLine("\nLütfen bir kart seçin (1-6) ya da çıkmak için '0' tuşuna basın:");
            string giris = Console.ReadLine();

            if (giris == "0")
            {
                Console.WriteLine("Oyunu bitirdiniz. İyi günler!");
                break;
            }

            if (int.TryParse(giris, out int secim) && secim >= 1 && secim <= 6)
            {
                Random random = new Random();
                FutbolOyuncusu secilenOyuncu = futbolcular[random.Next(futbolcular.Count)];

                Console.Clear(); // Ekranı temizle
                secilenOyuncu.BilgileriYazdir();
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen 1 ile 6 arasında bir sayı girin veya '0' tuşuna basarak çıkın.");
            }
        }
    }
}

