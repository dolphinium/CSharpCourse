using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();

            ProductManager productManager = new ProductManager();
            //productManager.Add();
            //productManager.Update();

            Customer customer = new Customer();
            customer.City = "Eskişehir";
            customer.FirstName = "Yunus Emre";
            customer.LastName = "KORKMAZ";
            customer.Id = 4;

            Customer customer2 = new Customer
            {
                City = "Eskişehir",
                FirstName = "Sinem",
                Id = 1,
                LastName = "YÜKSEL"
            };
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    
    
}
