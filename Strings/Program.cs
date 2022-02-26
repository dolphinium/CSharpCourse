using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var city = ForEachCity();
            //string city1 = "Ankara";
            //string city2 = "İstanbul";
            //string result = city1 + city2;
            //Console.WriteLine(String.Format("{0}{1}",city1,city2));


            string sentence = "My name is YUNUS EMRE KORKMAZ";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            bool result3 = sentence.EndsWith("SKMAZ");
            var result4 = sentence.IndexOf("is");
            var result5 = sentence.IndexOf(" ");
            var result6 = sentence.Insert(0, "Hello ");
            var result7 = sentence.Substring(3,4);
            var result8 = sentence.Replace(" ", "-");
            var result9 = sentence.Remove(3,4);
            Console.WriteLine(result9);


            Console.ReadLine();
        }

        private static string ForEachCity()
        {
            string city = "Ankara".ToUpper();
            //Console.WriteLine(city[2]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            return city;
        }
    }
}
