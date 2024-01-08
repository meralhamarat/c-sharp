using System;

class Program
{
    // Delege tanımı
    delegate void MyDelegate(int x, int y);

    // Delege ile uyumlu olan metotlar
    static void Toplama(int x, int y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }

    static void Carpma(int x, int y)
    {
        Console.WriteLine($"{x} * {y} = {x * y}");
    }

    static void Bolme(int x, int y)
    {
        try
        {
            if (y == 0)
            {
                throw new ArgumentException("Bölme işlemi için payda sıfır olamaz.");
            }

            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }

    public Program()
    {
        // Delege tanımlama ve metotları ekleme
        MyDelegate delege = null;
        delege += Toplama;
        delege += Carpma;
        delege += Bolme;

        int X, Y;
        X = 18;
        Y = 3;

        // Delegeyi çağırma
        delege(X, Y);
    }

    static void Main()
    {
        new Program();
        Console.ReadLine();
    }
}
