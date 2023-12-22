using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> sarkiListesi = new List<string>
        {
            "Musa Gülsah - Beni Kandırdın",
            "Robert Hatemo - Senden Çok Var",
            "İsmail YK - Git Hadi Git",
            "Ceza - Holocoust",
            "Musa Gülsah - Göçtü Gitti",
            "Robert Hatemo - Aşk Çiçeğim",
            "İsmail YK - Bas Gaza",
            "Ceza - Araturka Faslı",
            // ... diğer şarkılar
        };

        Random random = new Random();
        int randomIndex = random.Next(sarkiListesi.Count);
        string randomSarki = sarkiListesi[randomIndex];

        Console.WriteLine($"İşte sana bir şarkı önerisi: {randomSarki}");

        Console.ReadLine(); // Konsolun kapatılmaması için bekleme
    }
}
