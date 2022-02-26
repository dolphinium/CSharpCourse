using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Add();
            //Console.WriteLine(Add2Numbers(5,20));
            Console.WriteLine(Multiply(3,100));
            Console.WriteLine(Multiply(3, 100,5));
            Console.WriteLine(Add4(3, 100, 5,4,5,6,4,4,2,7,2,78));
            Console.ReadLine();
         
        }

        // Methods are usually used for DRY Principle!
        private static void Add()
        {
            Console.WriteLine("Added!");
        }
        // Default parameter should be on the last variable
        private static int Add2Numbers(int number1, int number2=30)
        {
            return number1 + number2; 
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }


        // Params keyword is using for multiple parameters 
        public static int Add4(params int [] numbers)
        {
            return numbers.Sum();
        }

    }
}
