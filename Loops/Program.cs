using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop(number);
            //int number = 10;
            //DoWhile(number);
            //ForEach();
            Console.WriteLine(IsPrimeNumber(913345427));
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static void ForEach()
        {
            string[] students = new string[3] {"YUNUS", "EMRE", "KORKMAZ"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhile(int number)
        {
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop(int number)
        {
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
