/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Araba_Galerisi.cs                                                        */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;
using System.Collections.Generic;

class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string GovdeTipi { get; set; }
    public decimal Fiyat { get; set; }
    public int TaksitSayisi { get; set; }

    public Araba(string marka, string model, string govdeTipi, decimal fiyat, int taksitSayisi)
    {
        Marka = marka;
        Model = model;
        GovdeTipi = govdeTipi;
        Fiyat = fiyat;
        TaksitSayisi = taksitSayisi;
    }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", "Corolla", "Sedan", 150000, 12),
            new Araba("Toyota", "Rav4", "SUV", 200000, 18),
            new Araba("Toyota", "Yaris", "Hatchback", 120000, 10),
            new Araba("Honda", "Civic", "Sedan", 160000, 15),
            new Araba("Honda", "CR-V", "SUV", 220000, 24),
            new Araba("Honda", "Fit", "Hatchback", 130000, 12)
        };

        Console.WriteLine("Araba Galerisi");
        Console.WriteLine("---------------");

        // Kullanıcıdan araç modelini seçmesini iste
        Console.Write("Hangi araç modelini istiyorsunuz? (Örneğin: Corolla, Rav4, Yaris, Civic, CR-V, Fit): ");
        string kullaniciModel = Console.ReadLine();

        // Seçilen modelle eşleşen arabayı bul
        Araba secilenAraba = arabalar.Find(araba => araba.Model.Equals(kullaniciModel, StringComparison.OrdinalIgnoreCase));

        if (secilenAraba != null)
        {
            Console.WriteLine($"Seçilen Araç: {secilenAraba.Marka} {secilenAraba.Model} ({secilenAraba.GovdeTipi})");
            Console.WriteLine($"Fiyat: {secilenAraba.Fiyat:C}, Taksit Sayısı: {secilenAraba.TaksitSayisi} ay");
        }
        else
        {
            Console.WriteLine("Geçersiz araç modeli seçildi.");
        }

        Console.ReadLine();
    }
}
