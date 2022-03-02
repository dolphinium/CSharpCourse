using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();   //  void and no parameters methods

    public delegate void MyDelegate2(string text);  // void and parameter

    public delegate int MyDelegate3(int number1, int number2);  // int and 2 parameters

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;  // special delegate for sending message 
            myDelegate += customerManager.ShowAlert;  // syntax of adding operations to delegate 

            myDelegate -= customerManager.SendMessage;  // syntax of deleting operations of delegate

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Maths maths = new Maths();

            MyDelegate3 myDelegate3 = maths.Add;
            
            myDelegate3 += maths.Multiply;
            var result = myDelegate3(2, 3);         
            Console.WriteLine(result);

            myDelegate2("Hello2");       //  the parameter of delegate will be used for both operations 


            myDelegate();   // usage of delegate

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Alert!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Maths
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
