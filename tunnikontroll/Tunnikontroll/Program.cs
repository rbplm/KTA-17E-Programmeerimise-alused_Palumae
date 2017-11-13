using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olen programm, mis ytleb sulle hinna soodustuse. Sisesta hind: ");
            string sisend = Console.ReadLine();
            int numbersisend = int.Parse(sisend);
            double allahindlus = 0;
            double allahindlus1 = 0;

            if (numbersisend > 50 && numbersisend < 250)
            {
                allahindlus = numbersisend / 100 * 10.0;
                allahindlus1 = numbersisend / 100 * 10.0;
                Console.WriteLine("Summa " + numbersisend + " tavakliendi allahindlus on 10% ehk: " + allahindlus + "eurot");
                Console.WriteLine("Summa " + numbersisend + " püsikliendi allahindlus on 20% ehk: " + allahindlus1 + "eurot");

            }

            if (numbersisend > 250 && numbersisend < 350)
            {
                allahindlus = numbersisend / 100 * 10.0;
                allahindlus1 = numbersisend / 100 * 10.0;
                Console.WriteLine("Summa " + numbersisend + " tavakliendi allahindlus on 10% ehk: " + allahindlus + "eurot");
                Console.WriteLine("Summa " + numbersisend + " püsikliendi allahindlus on 20 ehk: " + allahindlus1 + "eurot");
            }

            if (numbersisend > 350)
            {
                allahindlus = numbersisend / 100 * 10.0;
                allahindlus1 = numbersisend / 100 * 10.0;
                Console.WriteLine("Summa " + numbersisend + " tavakliendi allahindlus on 10% ehk: " + allahindlus + "eurot");
                Console.WriteLine("Summa " + numbersisend + " püsikliendi allahindlus on 20 %: " + allahindlus1 + "eurot");
            }

            Console.ReadLine();
        }
    }
}
