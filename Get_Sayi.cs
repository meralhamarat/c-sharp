/* ************************************************************************** */
/*                                                                            */
/*                                                                            */
/*   Get_Sayi.cs                                                              */
/*                                                                            */
/*   By: meralhamarat24@gmail.com                                             */
/*                                                                            */
/* ************************************************************************** */

using System

class X
{
    private int sayi;

    public X()
    {
        sayi = 10;
    }

    public X(int a)
    {
        sayi = 10 * a;
    }

    public int Get_Sayi()
    {
        return sayi;
    }
}

class Program
{
    static void Main(string[] args)
    {
        X X_nesne01 = new X();
        X X_nesne02 = new X(4);

        Console.WriteLine("X_nesne01 sayi: " + X_nesne01.Get_Sayi());
        Console.WriteLine("X_nesne02 sayi: " + X_nesne02.Get_Sayi());
    }
}
