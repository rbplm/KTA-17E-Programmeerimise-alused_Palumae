using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dd
{
    class Program
    {

        public class Dice
            {

                private Random Random = new Random();
                public int Roll (int sides)
            {
                               
                return Random.Next(1, sides +1);
            }
            }
        

        static void Main(string[] args)
        {
            Random rnd = new Random();

        
            int value = rnd.Next();
            
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            int n = 0;
            int m = 0;
            int total = 0;
            Dice dice = new Dice();

            Dice d6 = new Dice(6);
            
            for (int i = 0; i < 3; i++)
            {
                n = d6.Roll();
                Console.WriteLine($"1d6: {n}");
                total += n;
            }

            Dice d8 = new Dice(8);

            for (int i = 0; i < 2; i++)
            {
                m = d8.Roll();
                Console.WriteLine($"1d8: {m}");
                total += m;
            }

            
            

            Console.WriteLine();
            Console.WriteLine($"Roll total: {total}");
            Console.WriteLine();
            Console.Write("> ");

            Console.ReadLine();
        }
    }
}
