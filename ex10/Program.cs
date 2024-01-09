using System;
namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
        
            x = y;
            y = 30;
            Console.WriteLine(x);
        }
       
    }
}