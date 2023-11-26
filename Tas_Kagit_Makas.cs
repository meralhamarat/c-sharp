/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Tas_Kagit_Makas.cs                                                       */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Taş, kağıt, makas oyununa hoş geldiniz!");

        int bilgisayarKazanmaSayisi = 0;
        int oyuncuKazanmaSayisi = 0;

        for (int i = 0; i < 4; i++)
        {
            string kullaniciSecimi = KullaniciSecimAşaması();
            string bilgisayarSecimi = BilgisayarSecimAşaması();

            OyunSonucuAşaması(kullaniciSecimi, bilgisayarSecimi, ref bilgisayarKazanmaSayisi, ref oyuncuKazanmaSayisi);

            Console.WriteLine($"Oyuncu: {oyuncuKazanmaSayisi}  Bilgisayar: {bilgisayarKazanmaSayisi}");
        }

        if (oyuncuKazanmaSayisi > bilgisayarKazanmaSayisi)
        {
            Console.WriteLine("Oyuncu kazandı!");
        }
        else if (oyuncuKazanmaSayisi < bilgisayarKazanmaSayisi)
        {
            Console.WriteLine("Bilgisayar kazandı!");
        }
        else
        {
            Console.WriteLine("Berabere!");
        }
    }

    static string KullaniciSecimAşaması()
    {
        Console.Write("Seçiminizi yapın (taş, kağıt, makas): ");
        string kullaniciSecimi = Console.ReadLine().ToLower();

        while (kullaniciSecimi != "taş" && kullaniciSecimi != "kağıt" && kullaniciSecimi != "makas")
        {
            Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen taş, kağıt veya makas seçin.");
            Console.Write("Yeniden seçiminizi yapın: ");
            kullaniciSecimi = Console.ReadLine().ToLower();
        }

        return kullaniciSecimi;
    }

    static string BilgisayarSecimAşaması()
    {
        string[] secenekler = { "taş", "kağıt", "makas" };
        Random random = new Random();
        int index = random.Next(secenekler.Length);
        string bilgisayarSecimi = secenekler[index];

        Console.WriteLine($"Bilgisayarın seçimi: {bilgisayarSecimi}");

        return bilgisayarSecimi;
    }

    static void OyunSonucuAşaması(string kullanici, string bilgisayar, ref int bilgisayarKazanmaSayisi, ref int oyuncuKazanmaSayisi)
    {
        if (kullanici == bilgisayar)
        {
            Console.WriteLine("Berabere!");
        }
        else if ((kullanici == "taş" && bilgisayar == "makas") ||
                 (kullanici == "kağıt" && bilgisayar == "taş") ||
                 (kullanici == "makas" && bilgisayar == "kağıt"))
        {
            Console.WriteLine("Oyuncu kazandı!");
            oyuncuKazanmaSayisi++;
        }
        else
        {
            Console.WriteLine("Bilgisayar kazandı!");
            bilgisayarKazanmaSayisi++;
        }
    }
}
