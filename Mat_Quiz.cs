/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Mat_oru.cs                                                              */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Matematik Testine Hoş Geldiniz!");
        Console.WriteLine("Her sorunun cevabını girin. Hazır mısınız?\n");

        int dogruSayisi = 0;

        // Soru 1
        Console.WriteLine("Soru 1: √144 kaçtır?");
        double soru1Cevap = Convert.ToDouble(Console.ReadLine());
        if (Math.Abs(soru1Cevap - 12) < 0.001)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 12");
        }

        // Soru 2
        Console.WriteLine("\nSoru 2: log₂8 kaçtır?");
        double soru2Cevap = Convert.ToDouble(Console.ReadLine());
        if (Math.Abs(soru2Cevap - 3) < 0.001)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 3");
        }

        // Soru 3
        Console.WriteLine("\nSoru 3: (2^3) x (3^2) kaçtır?");
        int soru3Cevap = Convert.ToInt32(Console.ReadLine());
        if (soru3Cevap == 72)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 72");
        }

        // Soru 4
        Console.WriteLine("\nSoru 4: 5! (5 faktöriyel) kaçtır?");
        int soru4Cevap = Convert.ToInt32(Console.ReadLine());
        if (soru4Cevap == 120)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 120");
        }

        // Soru 5
        Console.WriteLine("\nSoru 5: 2^4 - 2^3 + 2^2 - 2^1 kaçtır?");
        int soru5Cevap = Convert.ToInt32(Console.ReadLine());
        if (soru5Cevap == 6)
        {
            Console.WriteLine("Doğru!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış. Doğru cevap: 6");
        }

        // Test sonuçlarını göster
        Console.WriteLine($"\nTesti tamamladınız! Toplam {dogruSayisi} soruya doğru cevap verdiniz.");

        // Programın kapanmasını bekliyoruz
        Console.ReadLine();
    }
}
