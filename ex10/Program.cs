using System;
namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, double, char, bool, decimal, float, enum, struct value types backed by stack
            int x = 10;
            int y = 20;
        
            x = y;
            y = 30;
            Console.WriteLine("x : " +x);
            
            // array, class, interface, delegate, string, object, dynamic reference types backed by heap
            int [] numbers1 = new int [] {1, 2, 3};
            int [] numbers2 = new int [] {4, 5, 6};
            numbers1 = numbers2;
            numbers2[0] = 400;
            Console.WriteLine("numbers1 : " +numbers1[0]);
        }
    }
}
