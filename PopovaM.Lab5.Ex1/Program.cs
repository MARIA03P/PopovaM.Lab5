using System;

namespace PopovaM.Lab5.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = -1, k = 1;
            Console.WriteLine("Выберите цикл: for, while, do-while");
            string name=Console.ReadLine();
            switch (name)
            {
                case "while":
                    x = -1;
                    while (x < 2)
                    {
                        k = 1;
                        while (k < 11)
                        {
                            double M = 2 * x / Math.Pow(k, (x - 3));
                            Console.Write($"{Math.Round(M, 2)}\t");
                            k++;
                            

                        }Console.WriteLine(); 
                        x += 0.1;
                        
                    }
                   
                    break;
                   
                case "do-while":
                    x = -1;
                    do
                    {
                        k = 1;
                        do
                        {
                            double F = 2 * x / Math.Pow(k, x - 3);
                            Console.Write($"{Math.Round(F, 2)}\t");

                            k++;
                            
                        } while (k < 11);
                        Console.WriteLine(); 
                        x+=0.1; 
                     
                    } while (x<2); 
                    
                    break;


                case "for":

                    for ( x = -1; x < 2; x += 0.1)
                    {
                        for (k = 1;  k < 11; k++)
                        {

                            double S = 2 * x / Math.Pow(k, (x - 3));
                            Console.Write($"{Math.Round(S, 2)}\t");
                        } 
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
