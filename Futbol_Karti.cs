using System;

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
        FutbolOyuncusu oyuncu1 = new FutbolOyuncusu("Lionel Messi", "Paris Saint-Germain", "Forvet", 90, 80);
        FutbolOyuncusu oyuncu2 = new FutbolOyuncusu("Cristiano Ronaldo", "Manchester United", "Forvet", 88, 85);
        FutbolOyuncusu oyuncu3 = new FutbolOyuncusu("Arda Turan", "Galatasaray", "Orta Saha", 85, 75);

        oyuncu1.BilgileriYazdir();
        oyuncu2.BilgileriYazdir();
        oyuncu3.BilgileriYazdir();

        Console.ReadLine();
    }
}
