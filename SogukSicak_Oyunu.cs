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
        OyunuBaslat();
    }

    static void OyunuBaslat()
    {
        Console.WriteLine("Sıcak-Soğuk Oyununa Hoş Geldiniz!");

        int toplamPuan = 0;

        while (true)
        {
            int puan = OyunuOyna();

            toplamPuan += puan;

            Console.WriteLine($"Toplam Puanınız: {toplamPuan}");

            Console.Write("Yeniden oynamak istiyor musunuz? (E/H): ");
            string cevap = Console.ReadLine();

            if (cevap.ToUpper() != "E")
            {
                break;
            }
        }

        Console.WriteLine("Oyun bitti. Toplam Puanınız: " + toplamPuan);
    }

    static int OyunuOyna()
    {
        int hedefSayi = new Random().Next(1, 101);
        int tahminHakki = 20; // Tahmin hakkını 20 yap
        int puan = 100;

        while (tahminHakki > 0)
        {
            Console.Write("Tahmininiz: ");
            string tahminStr = Console.ReadLine();

            if (int.TryParse(tahminStr, out int tahmin))
            {
                if (tahmin == hedefSayi)
                {
                    Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz. Hedef sayı: {hedefSayi}");
                    return puan;
                }
                else
                {
                    string durum = SogukSicakDurumu(tahmin, hedefSayi);
                    Console.WriteLine(durum);

                    // Her yanlış tahminde 5 puan düşür
                    puan -= 5;
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz.");
                continue; // Geçersiz giriş olduğunda döngüyü başa al
            }

            tahminHakki--;
            if (tahminHakki > 0)
            {
                Console.WriteLine($"Kalan tahmin hakkınız: {tahminHakki}");
            }
        }

        Console.WriteLine($"Üzgünüm! Tahmin hakkınız bitti. Hedef sayı: {hedefSayi}");
        return 0;
    }

    static string SogukSicakDurumu(int tahmin, int hedefSayi)
    {
        int fark = Math.Abs(tahmin - hedefSayi);

        if (fark == 0)
        {
            return "Vuhuu tebriklerr! Tam isabet!";
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
