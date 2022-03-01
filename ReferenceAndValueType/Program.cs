using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = new string[] {"Ankara","Adana","Afyon"};  // 101 ref num for cities1
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };  // 102 ref num for cities2
            cities2 = cities1;  // new ref of cities2 = 101
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }
}
