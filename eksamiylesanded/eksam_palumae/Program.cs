using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace eksam_palumae
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
                        
            Console.WriteLine("Sisesta nimed");
            List<string> items = new List<string>();

            string userInput = "ahaa";
            

            while (userInput != "-1")
            {
                
                userInput = Console.ReadLine();
                string InputToUpperCase = UppercaseFirst(userInput);
                


                items.Add(InputToUpperCase);
            }

            items.ForEach(Console.WriteLine);
            

            Console.ReadLine();



        }

    }
}
