// Aşağıdaki kod kullanıcıdan bir yarıçap değeri girilmesini ve girilen yarıçap değeriyle alan ve çevre hesaplamalarının yapılmasını sağlar.

/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Cember.cs                                                                */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

class Program
{
    static void Main()
    {
        double radius;

        do
        {
            Console.Write("Dairenin yarıçapını girin: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out radius) && radius > 0)
            {
                // Geçerli bir yarıçap değeri alındı, işlemlere devam et
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Pozitif bir sayı girin.");
            }

        } while (true);

        // Alan ve çevre hesaplamaları
        double area = Math.PI * Math.Pow(radius, 2);
        double circumference = 2 * Math.PI * radius;

        // Sonuçları ekrana yazdır
        Console.WriteLine($"Dairenin Alanı: {area:F2}");
        Console.WriteLine($"Dairenin Çevresi: {circumference:F2}");

        Console.ReadLine();
    }
}
