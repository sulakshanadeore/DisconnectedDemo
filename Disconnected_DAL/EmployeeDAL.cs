using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_DAL
{
    public class EmployeeDAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public EmployeeDAL()
        {
            ds = new DataSet();//in memory cache called DataSet
             cn = new SqlConnection(ConfigurationManager.ConnectionStrings["nwndCnStr"].ConnectionString);
        }

        public int RowCountEmployees()
        {
            da = new SqlDataAdapter("select * from employees", cn);

            //da takes the data from the database using a select query and will disconnect
            //from the database server once it fills/pushes the data to the DataSet
            
            da.Fill(ds, "employees");//disconnect from our database server
                                     //Single dataset object can hold multiple tables inside it
                                     //To identify each table uniquely we can use a index or name.
                                     //index starts with 0, but better to work with name.
            DataTable dt_empdata = ds.Tables["employees"];
            int empcnt = dt_empdata.Rows.Count;
            return empcnt;


        }

        public int RowCountProducts()
        {
            da = new SqlDataAdapter("select * from products", cn);
            da.Fill(ds, "products");//1


            
            DataTable dt_prodData = ds.Tables["products"];


            int prodcnt = dt_prodData.Rows.Count;
            return prodcnt;
           
        }
         
       
    }
}
