using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman

{
    
    class Program
    {
        static void Main(string[] args)

        {
            

            //massiiv eelvalitud sõnu
            //arvuti valib suvalise sõna
            // char[] characters = "this is a test".ToCharArray();
            // kas see sõna sisaldab pakutud tähte?

            //annab võimaluse ära arvata tähti
            //viis korda saab proovida

            Console.WriteLine("Ülespoomismäng. Arva ära sõna pakkudes, mis tähti see sõna sisaldab." +
                "valesti saad arvata 5 korda");

            String[] words = { "TAEVAS", "PILV", "MAJA" };
            int randomIndex = new Random().Next(0, words.Length);
            string theword = words[randomIndex];

            int length = theword.Length;

            char[] characters = theword.ToCharArray();

            Console.WriteLine(characters);

            List<char> userLetters = new List<char>();

            Console.WriteLine("Paku täht: ");
            char input = Console.ReadKey().KeyChar;

            userLetters.Add(input);
            
            Console.WriteLine();

            if (characters.Contains(input))
            {
                for (int i = 0; i < length; i++)
                {
                    if (characters[i] != input)
                                            
                    Console.Write("_");

                    if (characters[i] == input)

                        Console.Write(characters[i]);

                }
                

             }

                Console.WriteLine();


                Console.ReadKey();

            

        }
    }
}
