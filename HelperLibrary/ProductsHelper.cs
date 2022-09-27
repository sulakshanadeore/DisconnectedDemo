using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disconnected_DAL;
namespace HelperLibrary
{
   public class ProductsHelper
    {
        ProductsDAL dal = new ProductsDAL();

        public int RowCountProducts()
        {
            return dal.RowCountProducts();

        }
    }
}
