using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();

            Console.ReadLine();
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }
            public virtual void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer : Database
        {

            // Virtual methods are used on the siblings for changing the attribute of base class.
            // Override than space for the changing the attribute of the target method.
            public override void Add()
            {
                Console.WriteLine("Added by Sql Code");
                //base.Add();
            }
        }
        class MySqlServer : Database
        {

        }
    }
}
