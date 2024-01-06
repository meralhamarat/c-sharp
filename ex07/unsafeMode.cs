using System;
using System.Threading;

class Program
{
    static int sharedNumber = 0;
    static object lockObject = new object();

    static unsafe void Main()
    {
        // İki farklı thread oluşturuyoruz.
        Thread thread1 = new Thread(IncrementSharedNumber);
        Thread thread2 = new Thread(IncrementSharedNumber);

        // Thread'leri başlatıyoruz.
        thread1.Start();
        thread2.Start();

        // Thread'lerin tamamlanmasını bekliyoruz.
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Sonuç: " + sharedNumber);
    }

    static unsafe void IncrementSharedNumber()
    {
        for (int i = 0; i < 100000; i++)
        {
            lock (lockObject)
            {
                // sharedNumber'ı artırma işlemi.
                sharedNumber++;
            }
        }
    }
}
