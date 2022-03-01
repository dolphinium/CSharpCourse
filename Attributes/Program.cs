using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "Korkmaz",
                Age = 20
            };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]  // Multiple attributes at only one property
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }

    class CustomerDal
    {
        [Obsolete("Use AddNew() instead of this!")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }

        public void AddNew(Customer customer)
        {

        }
    }

    [AttributeUsage(AttributeTargets.Property,AllowMultiple = false)]  // Use pipe for multiple targets  ||| Allow multiple lets you use multiple attributes
    class RequiredPropertyAttribute:Attribute
    {
        
    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }
}
