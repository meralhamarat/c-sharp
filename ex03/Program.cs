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
        Console.WriteLine("Adam Asmaca Oyunu'na Hoşgeldiniz!");
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
            Console.Clear();
            DrawHangman(kalanCan);
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
                    Console.Clear();
                    DrawHangman(kalanCan);
                    Console.WriteLine("Tebrikler, kelimeyi doğru tahmin ettiniz!");
                    break;
                }
            }
            else
            {
                Console.Clear();
                DrawHangman(--kalanCan);
                Console.WriteLine("Hatalı tahmin, bir can kaybettiniz.");
            }

            if (Array.IndexOf(dogruTahminler, '_') == -1)
            {
                Console.Clear();
                DrawHangman(kalanCan);
                Console.WriteLine("Tebrikler, kelimeyi doğru tahmin ettiniz!");
                break;
            }
        }

        if (kalanCan == 0)
        {
            Console.WriteLine($"Üzgünüm, canlarınız tükendi. Doğru kelime: {secilenKelime}");
        }

        Console.ReadLine();
    }

    static void DrawHangman(int wrongGuessCount)
    {
        Console.WriteLine("  +---+");
        Console.WriteLine("  |   |");

        switch (wrongGuessCount)
        {
            case 1:
                Console.WriteLine("  O   |");
                break;
            case 2:
                Console.WriteLine("  O   |");
                Console.WriteLine("  |   |");
                break;
            case 3:
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|   |");
                break;
            case 4:
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                break;
            case 5:
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine(" /    |");
                break;
            case 6:
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine(" / \\  |");
                break;
        }

        Console.WriteLine("=========");
    }
}
