using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                CustomException();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

            }

            HandleException(() =>
            {
                CustomException();
            });

            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
               
            }
        }

        private static void CustomException()
        {
            List<string> students = new List<string> {"Yunus", "Emre", "KORKMAZ"};
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record can not found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] {"Yunus", "Emre", "KORKMAZ"};

                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}