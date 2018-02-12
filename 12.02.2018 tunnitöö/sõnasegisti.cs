using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sõnasegisti
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Sisesta lause, ma segan kõik tähed va esimene ja viimane täht: ");
            string lause = Console.ReadLine();
                        
            Random rng = new Random();
            string[] words = lause.Split(' ');

            foreach (string word in words)
            {
                string w0rd = word;
                char[] karakterid = word.ToCharArray();
                int pikkus = karakterid.Length;
                

                int number = 0;


                Console.Write(karakterid[0]);
                for (int i = 1; i < word.Length - 1; i++)
                {
                    uuesti:
                    number = rng.Next(1, word.Length - 1);
                    
                    if (karakterid.Contains(karakterid[number]))
                    {
                        if (karakterid[number] == '*')
                            goto uuesti;

                        Console.Write(karakterid[number]);
                        karakterid[number] = '*';

                    }
                }
                Console.Write(karakterid[pikkus-1]);
                Console.Write(" ");
            }
                                            
            
            Console.ReadLine();
        }
    }
}
