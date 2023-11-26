/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Banka_Hesabı.cs                                                          */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class BankaHesabi
{
    private string hesapSahibi;
    private string hesapNumarasi;
    private decimal bakiye;

    public string HesapSahibi
    {
        get { return hesapSahibi; }
        set { hesapSahibi = value; }
    }

    public string HesapNumarasi
    {
        get { return hesapNumarasi; }
        set { hesapNumarasi = value; }
    }

    public decimal Bakiye
    {
        get { return bakiye; }
        set
        {
            if (value >= 0) // Bakiye negatif olamaz
                bakiye = value;
            else
                Console.WriteLine("Hatalı bakiye degeri girdiniz.");
        }
    }

    public BankaHesabi(string hesapSahibi, string hesapNumarasi, decimal bakiye)
    {
        this.hesapSahibi = hesapSahibi;
        this.hesapNumarasi = hesapNumarasi;
        this.Bakiye = bakiye; // Bakiye property'si aracılığıyla değeri atar ve bakiye sınırlamasını kontrol eder.
    }

    public void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"{hesapSahibi} adli hesaba {miktar} TL yatirildi. Yeni bakiye: {Bakiye} TL");
    }

    public void ParaCek(decimal miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{hesapSahibi} adli hesaptan {miktar} TL cekildi. Yeni bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye. Islem gerceklestirilemedi.");
        }
    }

    public void HesapBilgileriYazdir()
    {
        Console.WriteLine($" Hesap Sahibi: {HesapSahibi}\n Hesap Numarasi: {HesapNumarasi}\n Bakiye: {Bakiye} TL");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Banka Hesabi Olusturma");

        Console.Write("Hesap Sahibi: ");
        string hesapSahibi = Console.ReadLine();

        Console.Write("Hesap Numarasi: ");
        string hesapNumarasi = Console.ReadLine();

        Console.Write("Bakiye: ");
        decimal bakiye;
        while (!decimal.TryParse(Console.ReadLine(), out bakiye) || bakiye < 0)
        {
            Console.WriteLine("Gecersiz bakiye degeri. Lutfen pozitif bir sayi girin.");
            Console.Write("Bakiye:\n ");
        }

        BankaHesabi hesap = new BankaHesabi(hesapSahibi, hesapNumarasi, bakiye);

        Console.WriteLine("\nBanka Hesabi Olusturuldu:\n");
        hesap.HesapBilgileriYazdir();

        Console.WriteLine("\nPara Yatirma");
        Console.Write("Yatirilacak Miktar: ");
        decimal yatirilanMiktar;
        while (!decimal.TryParse(Console.ReadLine(), out yatirilanMiktar) || yatirilanMiktar < 0)
        {
            Console.WriteLine("Gecersiz miktar. Lutfen pozitif bir sayi girin.");
            Console.Write("Yatirilacak Miktar: ");
        }

        hesap.ParaYatir(yatirilanMiktar);
        hesap.HesapBilgileriYazdir();

        Console.WriteLine("\nPara Cekme");
        Console.Write("Cekilecek Miktar: ");
        decimal cekilenMiktar;
        while (!decimal.TryParse(Console.ReadLine(), out cekilenMiktar) || cekilenMiktar < 0)
        {
            Console.WriteLine("Gecersiz miktar. Lutfen pozitif bir sayi girin.");
            Console.Write("Cekilecek Miktar: ");
        }

        hesap.ParaCek(cekilenMiktar);
        hesap.HesapBilgileriYazdir();

        Console.WriteLine("\nProgrami sonlandirmak icin '9' tusuna basin...");
        while (Console.ReadKey().Key != ConsoleKey.D9) { } // Concole.Key tuş bilgilerini içerip davranısları kontol eden anahtar
    }
}
