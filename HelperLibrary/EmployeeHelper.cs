using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disconnected_DAL;
using DisconnectedBLL;
namespace HelperLibrary
{
    public class EmployeeHelper
    {

        EmployeeDAL dal = new EmployeeDAL();

        public int RowCountEmployees()
        {
            return dal.RowCountEmployees();
        
        }
        public int RowCountProducts()
        {
            return dal.RowCountProducts();

        }

    }
}
