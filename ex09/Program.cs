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
        if (y != 0)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        else
        {
            Console.WriteLine("Bölme işlemi tanımsız (y = 0).");
        }
    }

    public Program()
    {
        // Delege tanımlama ve metotları ekleme
        MyDelegate delege = null;
        delege += new MyDelegate(Toplama);
        delege += new MyDelegate(Carpma);
        delege += new MyDelegate(Bolme);

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
