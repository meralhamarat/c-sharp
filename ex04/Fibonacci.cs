using System;

class Program
{
    // Fibonacci hesaplama fonksiyonu
    static void FibonacciHesapla(int n)
    {
        int a = 0, b = 1, c;

        Console.WriteLine("Fibonacci Sayıları:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            c = a + b;
            a = b;
            b = c;
        }
    }

    static void Main()
    {
        // Kullanıcıdan alınan sayıya kadar olan Fibonacci sayılarını hesaplayalım
        Console.Write("Kaç adet Fibonacci sayısı gösterilsin? ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        FibonacciHesapla(sayi);

        // Programın kapanmaması için bir tuşa basmayı bekleyelim
        Console.ReadLine();
    }
}
