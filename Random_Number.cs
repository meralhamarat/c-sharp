using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rastgele Sayı Üretici Programına Hoş Geldiniz!");

        // Rastgele sayı üretici nesnesi oluştur
        Random randomGenerator = new Random();

        // 1 ile 100 arasında rastgele bir sayı üret
        int rastgeleSayi = randomGenerator.Next(1, 101);

        Console.WriteLine($"Üretilen rastgele sayı: {rastgeleSayi}");

        Console.ReadLine(); // Konsol penceresini açık tut
    }
}
