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
        Console.WriteLine($"Oyuncu Adı: {Ad}");
        Console.WriteLine($"Takım: {Takim}");
        Console.WriteLine($"Pozisyon: {Pozisyon}");
        Console.WriteLine($"Hız: {Hiz}");
        Console.WriteLine($"Dayanıklılık: {Dayaniklilik}");
        Console.WriteLine();
    }
}

class Program
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

        foreach (var oyuncu in futbolcular)
        {
            oyuncu.BilgileriYazdir();
        }

        Console.ReadLine();
    }
}
