using System;

public class Kisiler
{
    private int y;
    private string i;

    public Kisiler()
    {
        y = 18;
        i = "Yok";
    }

    public Kisiler(string ad, int yas)
    {
        y = yas;
        i = ad;
    }

    public int Yas
    {
        get { return y; }
        set { y = value; }
    }

    public string Isim
    {
        get { return i; }
        set { i = value; }
    }

    public void EkranaYaz()
    {
        Console.WriteLine("Adım: " + i);
        Console.WriteLine("Yaşım: " + y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kisiler kisi1 = new Kisiler();
        kisi1.EkranaYaz();

        Kisiler kisi2 = new Kisiler("Ahmet", 25);
        kisi2.EkranaYaz();
    }
}
