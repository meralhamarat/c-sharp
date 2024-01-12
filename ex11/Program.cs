using System;

public sealed class Singleton
{
    private static int instanceCounter = 0;

    // Private ve static bir instance değişkeni tanımlıyoruz.
    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

    // Constructor'ı private yaparak dışarıdan yeni örneklerin oluşturulmasını engelliyoruz.
    private Singleton()
    {
        instanceCounter++;
        Console.WriteLine($"Instances created: {instanceCounter}");
    }

    // Dışarıdan Singleton örneğini almak için bu metodu kullanıyoruz.
    public static Singleton Instance
    {
        get { return instance.Value; }
    }

    // Singleton sınıfına ait başka bir işlev
    public void SomeMethod()
    {
        Console.WriteLine("Singleton method called.");
    }
}

class Program
{
    static void Main()
    {
        // Singleton örneğini alıyoruz.
        Singleton instance1 = Singleton.Instance;

        // Başka bir referans üzerinden aynı Singleton örneğini alıyoruz.
        Singleton instance2 = Singleton.Instance;

        // İki referansın da aynı örneği gösterip göstermediğini kontrol ediyoruz.
        if (instance1 == instance2)
        {
            Console.WriteLine("Both instances are the same.");
        }

        // Singleton sınıfının bir metodunu çağırıyoruz.
        instance1.SomeMethod();

        Console.ReadLine();
    }
}
