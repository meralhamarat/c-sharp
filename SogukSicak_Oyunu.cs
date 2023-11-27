using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sıcak-Soğuk Oyununa Hoş Geldiniz.");
        Console.WriteLine("Bilgisayar 1 ile 100 arasında bir sayı tuttu. Tahmininizi girin.");

        // Bilgisayarın aklındaki sayı
        int hedefSayi = new Random().Next(1, 101);

        while (true)
        {
            // Kullanıcının tahmini alınır
            Console.Write("Tahmininiz: ");
            string tahminStr = Console.ReadLine();

            if (int.TryParse(tahminStr, out int tahmin))
            {
                // Tahmin kontrolü yapılır
                if (tahmin == hedefSayi)
                {
                    Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    break;
                }
                else
                {
                    // Sıcak-Soğuk durumunu kontrol eder
                    string durum = SogukSicakDurumu(tahmin, hedefSayi);
                    Console.WriteLine(durum);
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz.");
            }
        }
    }

    // Sıcak-Soğuk durumunu kontrol eden fonksiyon
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
