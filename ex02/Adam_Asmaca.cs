/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Adam_Asmaca.cs                                                           */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Adam Asmaca Oyunu'na Hosgeldiniz!");
        Console.WriteLine("  +---+");
        Console.WriteLine("  |   |");
        Console.WriteLine("      |");
        Console.WriteLine("      |");
        Console.WriteLine("      |");
        Console.WriteLine("      |");
        Console.WriteLine("=========");

        string[] kelimeler = { "greyfurt", "avokado", "mandalina", "bilgisayar", "program" };
        Random random = new Random();
        string secilenKelime = kelimeler[random.Next(0, kelimeler.Length)];

        char[] dogruTahminler = new char[secilenKelime.Length];
        for (int i = 0; i < dogruTahminler.Length; i++)
        {
            dogruTahminler[i] = '_';
        }

        int kalanCan = 6;

        while (kalanCan > 0)
        {
            Console.WriteLine($"Kelime: {string.Join(" ", dogruTahminler)}");
            Console.WriteLine($"Kalan Can: {kalanCan}");

            Console.Write("Bir harf girin: ");
            char tahmin = Char.ToLower(Console.ReadLine()[0]); // Küçük harfe çevirme

            if (secilenKelime.Contains(tahmin))
            {
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == tahmin)
                    {
                        dogruTahminler[i] = tahmin;
                    }
                }

                if (!dogruTahminler.Contains('_'))
                {
                    Console.WriteLine("Tebrikler, kelimeyi doğru tahmin ettiniz!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Hatalı tahmin, bir can kaybettiniz.");
                kalanCan--;
            }
        }

        if (kalanCan == 0)
        {
            Console.WriteLine($"Üzgünüm, canlarınız tükendi. Doğru kelime: {secilenKelime}");
        }

        Console.ReadLine();
    }
}
