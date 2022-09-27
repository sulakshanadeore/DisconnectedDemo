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
   public class ProductsDAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public ProductsDAL()
        {
            ds = new DataSet();//in memory cache called DataSet
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["nwndCnStr"].ConnectionString);
        }
        public int RowCountProducts()
        {
            da = new SqlDataAdapter("select * from products", cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "products");//1



            DataTable dt_prodData = ds.Tables["products"];


            int prodcnt = dt_prodData.Rows.Count;
            return prodcnt;

        }
    }
}
