using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("DC Evreni Karakter Testine Hoş Geldiniz!");

        Console.Write("1. Hangi süper gücü tercih edersiniz? (a) Uçma (b) Zamanı durdurma (c) Şekil değiştirme: ");
        char soru1 = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("2. Hangi hayvana dönüşmek isterdiniz? (a) Kurt (b) Kartal (c) Goril: ");
        char soru2 = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();


        Console.Write("4. Hangi saç modelini tercih edersin? (a) Düz ve uzun (b) Kıvırcık ve kısa (c) Dalgalı ve orta: ");
        char soru4 = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("5. En sevdiğin ders hangisidir? (a) Fen (b) Sanat (c) Spor: ");
        char soru5 = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("6. En çok korktuğun şey nedir? (a) Yalnız kalmak (b) Yükseklik (c) Böcekler ");
        char soru6 = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("7. Akşam yemeği için neyi tercih edersin? (a) Pizza (b) Sushi (c) Steak: ");
        char soru7 = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        string batman = "Batman";
        string superman = "Superman";
        string wonderWoman = "Wonder Woman";
        string flash = "The Flash";
        string aquaman = "Aquaman";

        int batmanPuani = 0;
        int supermanPuani = 0;
        int wonderWomanPuani = 0;
        int flashPuani = 0;
        int aquamanPuani = 0;

        // Sorulara göre puanları hesapla
        if (soru1 == 'a') supermanPuani++;
        else if (soru1 == 'b') wonderWomanPuani++;
        else if (soru1 == 'c') flashPuani++;

        if (soru2 == 'a') batmanPuani++;
        else if (soru2 == 'b') supermanPuani++;
        else if (soru2 == 'c') aquamanPuani++;

        // 3. soru silindi.

        if (soru4 == 'a') supermanPuani++;
        else if (soru4 == 'b') flashPuani++;
        else if (soru4 == 'c') batmanPuani++;

        if (soru5 == 'a') batmanPuani++;
        else if (soru5 == 'b') wonderWomanPuani++;
        else if (soru5 == 'c') aquamanPuani++;

        if (soru6 == 'a') wonderWomanPuani++;
        else if (soru6 == 'b') supermanPuani++;
        else if (soru6 == 'c') flashPuani++;

        if (soru7 == 'a') batmanPuani++;
        else if (soru7 == 'b') aquamanPuani++;
        else if (soru7 == 'c') supermanPuani++;

        // En yüksek puana sahip karakteri bul
        if (batmanPuani > supermanPuani && batmanPuani > wonderWomanPuani && batmanPuani > flashPuani && batmanPuani > aquamanPuani)
        {
            Console.WriteLine($"\nSiz, {batman}'a daha çok benziyorsunuz!");
        }
        else if (supermanPuani > batmanPuani && supermanPuani > wonderWomanPuani && supermanPuani > flashPuani && supermanPuani > aquamanPuani)
        {
            Console.WriteLine($"\nSiz, {superman}'a daha çok benziyorsunuz!");
        }
        else if (wonderWomanPuani > batmanPuani && wonderWomanPuani > supermanPuani && wonderWomanPuani > flashPuani && wonderWomanPuani > aquamanPuani)
        {
            Console.WriteLine($"\nSiz, {wonderWoman}'a daha çok benziyorsunuz!");
        }
        else if (flashPuani > batmanPuani && flashPuani > supermanPuani && flashPuani > wonderWomanPuani && flashPuani > aquamanPuani)
        {
            Console.WriteLine($"\nSiz, {flash}'a daha çok benziyorsunuz!");
        }
        else
        {
            Console.WriteLine($"\nSiz, {aquaman}'a daha çok benziyorsunuz!");
        }
    }
}


        Console.WriteLine("=========");
    }
}
