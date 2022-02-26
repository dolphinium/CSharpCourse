using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];

            string[] students2 = {"Yunus", "Emre", "KORKMAZ"};

            foreach (var student in students2)
            {
             //   Console.WriteLine(student);
            }


            // Multi-dimensional Array Declaration
            string[,] regions = new string[7, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"asdf","asdf","asdfasd"},
                {"asdf","asdf","asdf"},
                {"asdfsdaf","asdfsadf","asdfsadf"},
                {"asdfasd","asdfasdf","asdfasdf"},
                {"asdfasdf","asgasdg","asgdasdgsad"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                    
                }
                Console.WriteLine("***********");
            }
           

            Console.ReadLine();
        }
    }
}
