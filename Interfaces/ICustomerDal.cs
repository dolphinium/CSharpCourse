﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added!");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted!");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");
        }
    }
    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added!");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted!");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    } 
}
