using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Create create = new Create();

            create.CreateTableProducts();
            create.CreateTableEmployees();
            create.CreateTableCustomers();
            create.CreateTableOrders();
            create.CreateTableOrderDetails();
        }
    }
}