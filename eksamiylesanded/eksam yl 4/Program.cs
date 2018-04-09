using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksam_yl_4
{
    class Program


    {
        static List<DateTime> SortAscending(List<DateTime> list)
        {
            list.Sort((a, b) => a.CompareTo(b));
            return list;
        }

            static void Main(string[] args)
        {
            //Programmis on defineeritud masiiv mis sisaldab umbes 30 erinevat timestamp’i mis illustreerivad inimeste sünniaega, näiteks vahemikus alates 1940 – 2010.Programmi ülesanne on leida nende timestamp’ide põhjal:
            //maksimaalne vanus
            //keskmine vanus aastates
            //minimaalne vanus
            //millisel kuul on kõige rohkem sünnipäevi
            //kõik timestamp’id sorteerituna kasvavalt


            DateTime start = new DateTime(1940, 2, 1);
            int range = (new DateTime(2010, 2, 3) - start).Days;
            Random gen = new Random();
            List<DateTime> dateTimeList = new List<DateTime>();
            List<int> vanused = new List<int>();


            for (int i = 0; i < 30; i++)

            {
                dateTimeList.Add(start.AddDays(gen.Next(range)));
            }

            foreach (var item in dateTimeList)
            {
                //Console.Write(item + "  ");
                int vanus = (new DateTime(2018, 4, 9) - item).Days;
                int vanusaastates = vanus / 365;
                vanused.Add(vanusaastates);
                
            }
            Console.WriteLine("Vanim: " + vanused.Max());
            Console.WriteLine("Noorim: " + vanused.Min());
            Console.WriteLine("Keskmine: " + vanused.Average());

            var list = dateTimeList.OrderBy(x => x.Date).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            }
    }
}
