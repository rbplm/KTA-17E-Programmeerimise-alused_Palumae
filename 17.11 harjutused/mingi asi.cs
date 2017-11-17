using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mingi 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sisesta korrutustabeli dimensioonid: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int input1 = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[input, input1];

            for (int i = 0; i < input; i++)
            {
                if (i == 0)
                    continue;

                for (int j = 0; j < input1; j++)
                {
                if (j == 0)
                    continue;
                    int multiplication = i * j;

                    Console.Write(multiplication);

                }

            }

            Console.ReadLine();
        }
    }
}
