using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;


namespace OfficeSupplyBLL
{
    public class ProductCatalog
    {
        public DataSet GetProductInfo()
        {
            DALProductCatalog prodCatalog = new DALProductCatalog();
            return prodCatalog.GetProductInfo();
        }
    }
}
