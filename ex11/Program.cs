using System;

public sealed class Singleton
{
    private static int instanceCounter = 0;

    // Define a private and static instance variable.
    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

    // Make the constructor private to prevent the creation of new instances from outside.
    private Singleton()
    {
        instanceCounter++;
        Console.WriteLine($"Instances created: {instanceCounter}");
    }

    // Use this method to get the Singleton instance from outside.
    public static Singleton Instance
    {
        get { return instance.Value; }
    }

    // Another function of the Singleton class.
    public void SomeMethod()
    {
        Console.WriteLine("Singleton method called.");
    }
}

class Program
{
    static void Main()
    {
        // Get the Singleton instance.
        Singleton instance1 = Singleton.Instance;

        // Get the same Singleton instance through another reference.
        Singleton instance2 = Singleton.Instance;

        // Check if both references point to the same instance.
        if (instance1 == instance2)
        {
            Console.WriteLine("Both instances are the same.");
        }

        // Call a method of the Singleton class.
        instance1.SomeMethod();

        Console.ReadLine();
    }
}
