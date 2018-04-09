using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksam_teine
{
    class Program
    {
        

            static string UppercaseFirst(string s)
            {

                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }

                return char.ToUpper(s[0]) + s.Substring(1);
            }
            static void Main(string[] args)
            {
               List<string> items = new List<string>();


            String[] nimed = { "kaur", "mattias", "kristel", "heleri", "trevor", "kristjan", "kelli", "kevin", "maarika", "laura" };
            

                string userinput = Console.ReadLine();

                string[] words = userinput.Split(' ');

                foreach (string word in words)
                {
                    
                    foreach (string x in nimed)
                    {
                    if (word.Contains(x))

                         
                         Console.Write(UppercaseFirst(word) + " ");
                    items.Add(word);


                    }

                    if (items.Contains(word))
                    Console.Write(word + " ");
                
            }
                Console.ReadLine();
            }
        
    }
}
