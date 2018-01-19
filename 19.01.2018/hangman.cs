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
            
            
            Console.WriteLine("Ülespoomismäng. Arva ära riigi nimi, pakkudes, mis tähti see nimi sisaldab.");
            Console.WriteLine("Valesti saad arvata 6 korda.");


            start:
            Console.WriteLine();
            String[] words = { "VENEMAA", "USBEKISTAN", "PAKISTAN", "BANGLADESH", "SOOME", "PRANTSUSMAA",
                "VENEZUELA", "MALAISIA", "SINGAPUR", "EGIPTUS", "HONDURAS", "AUSTRAALIA"};
            int randomIndex = new Random().Next(0, words.Length); //valib suvalise array "words" indeksi
            string theword = words[randomIndex];  //salvestab selle indeksi alt leitud sõna stringiks

            int length = theword.Length;  //võtab salvestatud sõna pikkuse, mida on hiljem vaja


            char[] characters = theword.ToCharArray();  //võtab salvestatud sõna lahti tähe kaupa

            List<string> userLetters = new List<string>();
            List<string> userLettersFalse = new List<string>();
            List<string> userLettersTrue = new List<string>();   //vajalikud listid
                        
            

            
            while (true)
                {
                    Console.WriteLine();
                    Console.Write("Paku täht: ");
                    char input_ = Console.ReadKey().KeyChar;
                    string input__ = input_.ToString();
                    string input = input__.ToUpper(); //muudab char inputi stringiks ja siis suurteks tähtedeks

                    var stringinput = input.ToString(); 
                    userLetters.Add(stringinput);     //võtab kasutaja sisendina ühe tähe, salvestab selle stringina ja salvestab kõik kasutaja sisestatud tähed listi "userLetters"

                    Console.WriteLine();
                                    
                    Console.WriteLine();

                    int sizeOfList = 0;  //loetleb listi "userLetters" suurust
                    int sizeOfList1 = 0;  //loetleb listi "userLettersTrue" suurust
                    int count = 0; //loetleb õigesti arvatud tähtede arvu



                    if (theword.Contains(input))  //kui valitud sõna sisaldab tähte
                    {
                        var stringinputTrue = input.ToString();
                        userLettersTrue.Add(stringinputTrue);
                        sizeOfList1 = userLettersTrue.Count;    //salvestab õigesti pakutud tähed, lisab need listi ja loetleb nende tähtede arvu

                        string.Join("", userLetters);  //liidab kasutaja sisestatu stringiks

                        for (int i = 0; i < length; i++)   
                        {
                            if (string.Join("", userLetters).Contains(characters[i]))  //kui kasutaja sisestatud tähed sisaldavad programmi valitud sõna array indeksi tähte
                            {
                                count++;    //loetleb need tähed
                                Console.Write(characters[i]);   //prindib programmi valitud sõna tähe

                                if (count == length)  // kui loetletud tähtede arv võrdub valitud sõna pikkusega
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Arvasid ära!");
                                    goto Finish; //läheb lõppu

                                }
                            }
                            if (string.Join("", userLetters).Contains(characters[i]) == false)  //juhul kui kasutaja sisestatud tähed ei sisalda valitud sõna array indeksi tähte

                                Console.Write("_"); //prindib "_"


                        }
                                     

                    Console.WriteLine();




                    }
                    if (theword.Contains(input) == false)  //kui programmi valitud sõna ei sisalda kasutaja sisendit
                    {
                        var stringinputFalse = input.ToString();
                        userLettersFalse.Add(stringinputFalse);
                        sizeOfList = userLettersFalse.Count; //salvestab valesti pakutud tähed, lisab need listi ja loetleb nende tähtede arvu
                    if (sizeOfList == 1)
                            Console.WriteLine("Vale täht. 5 katset veel");
                        if (sizeOfList == 2)
                            Console.WriteLine("Vale täht. 4 katset veel");
                        if (sizeOfList == 3)
                            Console.WriteLine("Vale täht. 3 katset veel");
                        if (sizeOfList == 4)
                            Console.WriteLine("Vale täht. 2 katset veel");
                        if (sizeOfList == 5)
                        Console.WriteLine("Vale täht. 1 katset veel");
                        
                        if (sizeOfList == 6)
                    {
                            Console.WriteLine();
                            Console.WriteLine("Kaotasid! Õige vastus " + theword);
                            break;
                        }
                    }



                }


            Finish:
            Console.WriteLine("Uuesti mängimiseks vajuta 'K' tähte, väljumiseks, mistahes muud klahvi.");
            char input1_ = Console.ReadKey().KeyChar;
            string input1__ = input1_.ToString();
            string input1 = input1__.ToUpper(); //muudab char inputi stringiks ja siis SUURTEKS TÄHTEDEKS
            Console.WriteLine();  
                        
            if (input1 == "K")
            {
                goto start;    //"K" tähe vajutamisel läheb algusesse
            }
            Console.ReadKey();


        }

    }
    }
