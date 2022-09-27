using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using HelperLibrary;

namespace DisconnectedDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeHelper helper = new EmployeeHelper();
            int empcnt = helper.RowCountEmployees();
            int prodcnt = helper.RowCountProducts();
            Console.WriteLine(empcnt);
            Console.WriteLine(prodcnt);

            Console.ReadKey();



        }
    }
}
