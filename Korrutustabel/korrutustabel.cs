using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korrutustabel
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int value = 0;

            Console.WriteLine("X |  1|   2|   3|   4|   5|   6|");
            Console.WriteLine("--------------------------------");
            
            for (int i = 1; i <= 6; i++)
            {
                

                Console.Write(i + " |");

                for (int j = 1; j <= 6; j++)
                {
                    
                    value = i * j;
                    if (value < 10)
                    Console.Write(" " + value + " | ");

                    if (value >= 10)
                        Console.Write(" " + value + "| ");

                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
