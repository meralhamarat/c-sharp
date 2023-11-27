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
    public string Yazdir
    {
        get { return x + "i" + (y >= 0 ? "+" : "") + y; }
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
