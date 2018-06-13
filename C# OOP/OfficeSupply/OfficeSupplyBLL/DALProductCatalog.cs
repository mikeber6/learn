using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace OfficeSupplyBLL
{
    public class DALProductCatalog
    {
        public DataSet GetProductInfo()
        {
            DataSet _dsProducts;
            string connString = DALUtility.GetSQLConnection("OSConnection");

            using (SqlConnection _conn = new SqlConnection(connString))
            {
                _dsProducts = new DataSet("Products");

                string strSQL = "Select CategoryId, Name, Description from Category";

                using (SqlCommand cmdSelCategory = new SqlCommand(strSQL, _conn))
                {                    
                    using (SqlDataAdapter daCategory = new SqlDataAdapter(cmdSelCategory))
                    {
                        daCategory.Fill(_dsProducts, "Category");
                    }
                }

                String strSQL2 = "select ProductId, CategoryId, Name, Description, UnitCost from Product";

                using (SqlCommand cmdSelProduct = new SqlCommand(strSQL2, _conn))
                {
                    using (SqlDataAdapter daProduct = new SqlDataAdapter(cmdSelProduct))
                    {
                        daProduct.Fill(_dsProducts, "Product");
                    }
                }

            }

            DataRelation drCategoryToProduct = new DataRelation("drCategoryToProduct", _dsProducts.Tables["Category"].Columns["CategoryId"], _dsProducts.Tables["Product"].Columns["CategoryId"], false);
            _dsProducts.Relations.Add(drCategoryToProduct);

            return _dsProducts;
        }
    }
}
