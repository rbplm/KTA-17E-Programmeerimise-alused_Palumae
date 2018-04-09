using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmas_yl
{
    class Program
    {



        static void Main(string[] args)

        {
            Console.Write("Sisesta algusaasta: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta alguskuu: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Sisesta alguspäev: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Sisesta lõppaasta: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Sisesta lõppkuu: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Sisesta lõpppäev: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("Sisesta kui mitu tulemust: ");
            int s = int.Parse(Console.ReadLine());


            DateTime start = new DateTime(a, b, c);
            int range = (new DateTime(d, e, f) - start).Days;
            Random gen = new Random();


            for (int i = 0; i < s; i++)

                {
                
                
                    Console.WriteLine(start.AddDays(gen.Next(range)));

                }

            

                Console.ReadLine();

            
        }
    }
}
