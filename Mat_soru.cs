using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Matematik Testine Hoş Geldiniz!");
        Console.WriteLine("Her sorunun cevabını girin. Hazır mısınız?\n");

        int dogruSayisi = 0;

        // Soru 1
        Console.WriteLine("Soru 1: 12 + 7 kaçtır?");
        int soru1Cevap = Convert.ToInt32(Console.ReadLine());
        if (soru1Cevap == 19)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 19");
        }

        // Soru 2
        Console.WriteLine("\nSoru 2: 8 x 6 kaçtır?");
        int soru2Cevap = Convert.ToInt32(Console.ReadLine());
        if (soru2Cevap == 48)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 48");
        }

        // Soru 3
        Console.WriteLine("\nSoru 3: 20 - 9 kaçtır?");
        int soru3Cevap = Convert.ToInt32(Console.ReadLine());
        if (soru3Cevap == 11)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 11");
        }

        // Soru 4
        Console.WriteLine("\nSoru 4: 15 / 3 kaçtır?");
        int soru4Cevap = Convert.ToInt32(Console.ReadLine());
        if (soru4Cevap == 5)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 5");
        }

        // Soru 5
        Console.WriteLine("\nSoru 5: 3^2 kaçtır?");
        int soru5Cevap = Convert.ToInt32(Console.ReadLine());
        if (soru5Cevap == 9)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 9");
        }

        // Test sonuçlarını göster
        Console.WriteLine($"\nTesti tamamladınız! Toplam {dogruSayisi} soruya doğru cevap verdiniz.");

        // Programın kapanmasını bekliyoruz
        Console.ReadLine();
    }
}
