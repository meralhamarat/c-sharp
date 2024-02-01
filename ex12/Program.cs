using System;

class Program
{
    public static void Main(string[] args)
    {
        int midterm;
        int midpercent;
        int pass;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Finalden kaç alsam geçerim uygulamasına hoşgeldiniz!");
        Console.WriteLine("-------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGray;

        Console.Write("Lütfen vize notunuzu giriniz: ");
        midterm = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen vize notunuzun yüzdeliğini giriniz: ");
        midpercent = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen geçme notunuzu giriniz: ");
        pass = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen final notunuzun yüzdeliğini giriniz: ");
        int finalpercent = Convert.ToInt32(Console.ReadLine());

        int final = (pass * 100 - (midterm * midpercent)) / finalpercent;        
        Console.WriteLine($"Finalden {final} almanız gerekiyor.");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
    } 
}
