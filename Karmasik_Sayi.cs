/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Karmasik_Sayi.cs                                                         */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System;

public class KarmasikSayi
{
    private int x;
    private int y;

    // Default constructor
    public KarmasikSayi()
    {
        x = 0; y = 0;
    }

    // Parametreli constructor
    public KarmasikSayi(int m, int n)
    {
        x = m; y = n;
    }

    // Property
    public override string ToString()
    {
        return $"{x}i{(y >= 0 ? "+" : "")}{y}";
    }

    // İki karmaşık sayıyı çıkarma
    public static KarmasikSayi operator -(KarmasikSayi c1, KarmasikSayi c2)
    {
        KarmasikSayi temp = new KarmasikSayi();
        temp.x = c1.x - c2.x;
        temp.y = c1.y - c2.y;
        return temp;
    }

    // İki karmaşık sayıyı toplama
    public static KarmasikSayi operator +(KarmasikSayi c1, KarmasikSayi c2)
    {
        KarmasikSayi temp = new KarmasikSayi();
        temp.x = c1.x + c2.x;
        temp.y = c1.y + c2.y;
        return temp;
    }

    // Karmaşık sayıyı bir skalerle çarpma
    public static KarmasikSayi operator *(KarmasikSayi c1, int scalar)
    {
        KarmasikSayi temp = new KarmasikSayi();
        temp.x = c1.x * scalar;
        temp.y = c1.y * scalar;
        return temp;
    }

    // Karmaşık sayıyı bir skalerle bölme
    public static KarmasikSayi operator /(KarmasikSayi c1, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        KarmasikSayi temp = new KarmasikSayi();
        temp.x = c1.x / divisor;
        temp.y = c1.y / divisor;
        return temp;
    }

    // Karmaşık sayıların eşit olup olmadığını kontrol etme
    public static bool operator ==(KarmasikSayi c1, KarmasikSayi c2)
    {
        return (c1.x == c2.x) && (c1.y == c2.y);
    }

    // Karmaşık sayıların eşit olmadığını kontrol etme
    public static bool operator !=(KarmasikSayi c1, KarmasikSayi c2)
    {
        return !(c1 == c2);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("****** Karmaşık Sayı Programı ******");
        Console.WriteLine("************************************");
        Console.WriteLine("Hoş geldiniz! Bu programda karmaşık sayılarla işlemler yapabilirsiniz.");
        Console.WriteLine("Lütfen aşağıdaki seçeneklerden birini belirleyerek işlemlere başlayın.\n");

        // Karmaşık sayı nesneleri oluşturuluyor
        KarmasikSayi sayi1 = new KarmasikSayi(3, 4);
        KarmasikSayi sayi2 = new KarmasikSayi(1, 2);

        while (true)
        {
            // Menü gösteriliyor
            Console.WriteLine("\nLütfen bir işlem seçin:");
            Console.WriteLine("1. Karmaşık Sayıları Topla");
            Console.WriteLine("2. Karmaşık Sayıları Çıkar");
            Console.WriteLine("3. Karmaşık Sayıyı Skalerle Çarp");
            Console.WriteLine("4. Karmaşık Sayıyı Skalerle Böl");
            Console.WriteLine("5. Çıkış");

            // Kullanıcının seçimini al
            int secim = Convert.ToInt32(Console.ReadLine());

            // Seçime göre işlem yap
            switch (secim)
            {
                case 1:
                    Console.WriteLine($"Toplama: {sayi1} + {sayi2} = {sayi1 + sayi2}");
                    break;

                case 2:
                    Console.WriteLine($"Çıkarma: {sayi1} - {sayi2} = {sayi1 - sayi2}");
                    break;

                case 3:
                    Console.WriteLine("Lütfen bir skaler girin:");
                    int skalerCarpim = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Skaler Çarpma: {sayi1} * {skalerCarpim} = {sayi1 * skalerCarpim}");
                    break;

                case 4:
                    Console.WriteLine("Lütfen bir bölen skaler girin:");
                    int skalerBolme = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Console.WriteLine($"Skaler Bölme: {sayi1} / {skalerBolme} = {sayi1 / skalerBolme}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Hata: {ex.Message}");
                    }
                    break;

                case 5:
                    Console.WriteLine("Programdan çıkılıyor. İyi günler!");
                    return;

                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }
}
