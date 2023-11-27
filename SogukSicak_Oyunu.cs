/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   SogukSicak_Oyunu.cs                                                      */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sıcak-Soğuk Oyununa Hoş Geldiniz!");
        Console.WriteLine("Bilgisayar 1 ile 100 arasında bir sayı tuttu. Tahmininizi girin.");

        // Bilgisayarın aklındaki sayı
        int hedefSayi = new Random().Next(1, 101);
        int tahminHakki = 5; // Örnek olarak 5 tahmin hakkı tanındı.

        while (tahminHakki > 0)
        {
            Console.Write("Tahmininiz: ");
            string tahminStr = Console.ReadLine();

            if (int.TryParse(tahminStr, out int tahmin))
            {
                if (tahmin == hedefSayi)
                {
                    Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz. Hedef sayı: {hedefSayi}");
                    break;
                }
                else
                {
                    string durum = SogukSicakDurumu(tahmin, hedefSayi);
                    Console.WriteLine(durum);
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz.");
            }

            tahminHakki--;
            Console.WriteLine($"Kalan tahmin hakkınız: {tahminHakki}");
        }

        if (tahminHakki == 0)
        {
            Console.WriteLine($"Üzgünüm! Tahmin hakkınız bitti. Hedef sayı: {hedefSayi}");
        }
    }

    static string SogukSicakDurumu(int tahmin, int hedefSayi)
    {
        int fark = Math.Abs(tahmin - hedefSayi);

        if (fark == 0)
        {
            return "Alev alev! Tam isabet!";
        }
        else if (fark <= 5)
        {
            return "Çok sıcak!";
        }
        else if (fark <= 10)
        {
            return "Sıcak.";
        }
        else if (fark <= 20)
        {
            return "Ilıman.";
        }
        else if (fark <= 30)
        {
            return "Soğuk.";
        }
        else
        {
            return "Buz gibi! Çok soğuk!";
        }
    }
}
