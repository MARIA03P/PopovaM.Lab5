using System;

namespace PopovaM.Lab5.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите переменную x");
            int x = Convert.ToInt32(Console.ReadLine());
            double y;
            if (x > 1)
            {
                y = x + 2;
            }
            else if (x < 0)
            {
                y = 2 * x;
            }
            else
            {
                y = 1 + 2 * x;
            }
            Console.WriteLine($"y = {y}");
        }
    }
}

