using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types 
            // Console.WriteLine("Hello World!");
            int number1 = 1000000000;
            long number2 = 1551982156;
            short number3 = 15126;
            byte number4 = 255;
            bool condition = true;
            char character = 'Ğ';
            double number5 = 3.1;
            Console.WriteLine("Number 1 is: {0}",number1);
            Console.WriteLine("Number 2 is: {0}", number2);
            Console.WriteLine("Number 3 is: {0}", number3);
            Console.WriteLine("Number 4 is: {0}", number4);
            Console.WriteLine("Number 5 is: {0}", number5);
            Console.WriteLine("Condition is: "+condition);
            Console.WriteLine("Character is: " + (int)character);
            Console.ReadLine();
        }
    }
}
