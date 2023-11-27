/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Asal_Sayi.cs                                                             */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int sayi))
        {
            bool asalMi = IsAsal(sayi);

            if (asalMi)
            {
                Console.WriteLine($"{sayi} bir asal sayıdır.");
            }
            else
            {
                int enKucukCarpan = EnKucukCarpaniBul(sayi);
                Console.WriteLine($"{sayi} bir asal sayı değildir. En küçük çarpanı: {enKucukCarpan}");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmelisiniz.");
        }
    }

    // Bir sayının asal olup olmadığını kontrol eden fonksiyon
    static bool IsAsal(int sayi)
    {
        if (sayi <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    // Bir sayının en küçük çarpanını bulan fonksiyon
    static int EnKucukCarpaniBul(int sayi)
    {
        for (int i = 2; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                return i;
            }
        }

        return -1; // Bu durumda sayının kendisi asal olabilir.
    }
}
