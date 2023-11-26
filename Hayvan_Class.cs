/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Hayvan_Class.cs                                                          */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

// Temel sınıf (base class) veya süper sınıf (super class) veya ana sınıf (parent class)
class Hayvan
{
    public string Ad { get; set; }
    public int Yas { get; set; }

    public Hayvan(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    public void BilgiVer()
    {
        Console.WriteLine($"{Ad} isimli hayvan, {Yas} yaşında.");
    }
}

// Alt sınıf (subclass) veya child class
class Kus : Hayvan
{
    public string Tur { get; set; }

    public Kus(string ad, int yas, string tur) : base(ad, yas)
    {
        Tur = tur;
    }

    // Üst sınıftan miras alınan metodu override ediyoruz
    public new void BilgiVer()
    {
        Console.WriteLine($"{Ad} isimli kuş, {Yas} yaşında ve {Tur} türündedir.");
    }
}

class Program
{
    static void Main()
    {
        // Hayvan sınıfından bir örnek oluşturalım
        Hayvan hayvan1 = new Hayvan("Leo", 5);
        hayvan1.BilgiVer();

        // Kuş sınıfından bir örnek oluşturalım
        Kus kus1 = new Kus("Sarı", 2, "Kanarya");
        kus1.BilgiVer();
    }
}
