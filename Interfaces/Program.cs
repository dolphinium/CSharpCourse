using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            //CustomerManagerDemo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void CustomerManagerDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer
            {
                Id = 1,
                Address = "tepebaşı/eskişehir",
                FirstName = "Yunus Emre",
                LastName = "KORKMAZ"
            });
            Student student = new Student
            {
                Id = 2,
                FirstName = "Halime Sinem",
                LastName = "YÜKSEL",
                Department = "Dietetics"
            };
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
