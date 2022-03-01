using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathematicalOperations mathematicalOperations = new MathematicalOperations(2, 3);
            //Console.WriteLine(mathematicalOperations.Add2());
            //Console.WriteLine(mathematicalOperations.Add(1, 3));

            var type = typeof(MathematicalOperations);
            // MathematicalOperations mathematicalOperations = (MathematicalOperations)Activator.CreateInstance(type,6,7);   //   creating a instance without new   and Type Casting via (MathematicalOperations)Activator.
            //Console.WriteLine(mathematicalOperations.Add(16,15));
            //Console.WriteLine(mathematicalOperations.Add2());

            var instance = Activator.CreateInstance(type, 6, 27);
            Console.WriteLine(instance.GetType().GetMethod("Add2").Invoke(instance,null));   // Invoking a method from instance.

            var methods = type.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine("Method name:  "+item.Name);
                foreach (var parameterInfo in item.GetParameters())
                {
                    Console.WriteLine("Parameters: {0}",parameterInfo.Name);
                }

                foreach (var customAttribute in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0}",customAttribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class MathematicalOperations
    {
        private int _num1;
        private int _num2;

        public MathematicalOperations()
        {
            
        }

        public MathematicalOperations(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiple(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Add2()
        {
            return _num1 + _num2;
        }
        [MethodName("Multiplication")]
        public int Multiple2()
        {
            return _num1 * _num2;
        }
    }

    class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
        
    }
}