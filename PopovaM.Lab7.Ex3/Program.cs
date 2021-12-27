using System;

namespace PopovaM.Lab7.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число:");
            int x = Convert.ToInt32(Console.ReadLine());

            int ev = 0, od = 0;

            while (x != 0)
            {
                int v = x % 10;
                if (v % 2 == 0)
                {
                    ev++;
                }
                else
                {
                    od++;
                    x /= 10;
                }
            }
            Console.WriteLine();
        }
    }
}

