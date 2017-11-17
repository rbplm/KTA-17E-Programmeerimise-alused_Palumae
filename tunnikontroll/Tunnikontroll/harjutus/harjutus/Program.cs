using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                Console.WriteLine("Taco Palenque");
                Console.WriteLine("1200 main ST");
                int numb = 1;
                double summa = 0;

                Console.WriteLine("----------------------------------------------------------");
                while (numb != 0)

                {

                    Console.Write("Enter price of food item [-1 to quit]:");
                    int input = int.Parse(Console.ReadLine());


                    summa += input;
                    if (input == -1)
                        break;

                }
                Console.WriteLine("----------------------------------------------------------");

                Console.WriteLine("Subtotal: €" + summa);
                double numb1 = summa / 100 * 15;
                Console.WriteLine("15% gratuity: €" + (double)numb1);
                Console.WriteLine(summa - numb1);

                Console.Write("Press any key to kcontinue: ");
                Console.ReadLine();


            }
        }

    }
}


