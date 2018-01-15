using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm mis lubab sisestada n+1 hulga erinevaid sõnu...");
            Console.WriteLine();
            List<string> words = new List<string>();

            while (true)
            {
                Console.Write("Sisesta sõna: ");
                var sisend = Console.ReadLine();

                if (sisend == "-1")
                    break;

                words.Add(sisend);
            }
            Console.WriteLine();
            Console.WriteLine($"Sisestasid sõnad: {string.Join(", ", words )}");

            var randomIndex = new Random().Next(0, words.Count -1);
            Console.WriteLine($"Valin nendest välja suvalise: {words[randomIndex]}");
            Console.ReadKey();

        }    
        
    }
}
