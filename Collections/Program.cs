using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);   
            }

            Console.WriteLine(dictionary.ContainsValue("tablo"));
            
            

            Console.ReadLine();
        }

        private static void List()
        {
            //ArrayList();

            List<string> cities = new List<string>
            {
                "ANKARA",
                "İstanbul"
            };

            Console.WriteLine(cities.Contains("ANKARA"));

            foreach (var city in cities)
            {
                //Console.WriteLine(city);   
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer{FirstName = "Yunus Emre",Id = 1});
            //customers.Add(new Customer { FirstName = "Sinem", Id = 2 });

            List<Customer> customers = new List<Customer>
            {
                new Customer {FirstName = "Yunus Emre", Id = 1},
                new Customer {FirstName = "Sinem", Id = 2}
            };


            var customer1 = new Customer
            {
                FirstName = "Taner",
                Id = 3
            };
            customers.Add(customer1);

            customers.AddRange(new Customer[4]
            {
                new Customer {Id = 4, FirstName = "Feyza"},
                new Customer {Id = 5, FirstName = "Yusuf"},
                new Customer {Id = 6, FirstName = "Hilal"},
                new Customer {Id = 7, FirstName = "Hülya"}
            });

            // customers.Clear();
            var count = customers.Count;

            Console.WriteLine(customers.Contains(customer1));

            var index = customers.LastIndexOf(customer1);
            Console.WriteLine("Index: {0}", index);

            customers.RemoveAll(c => c.FirstName == "Yunus Emre"); // predicate

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1); // Collections is not type safe. Because you can add any type of parameters(string, int, char...)
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
