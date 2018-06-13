using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace OfficeSupplyBLL
{
    public static class DALUtility
    {
        public static string GetSQLConnection(string name)
        {
            string returnValue = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }
            return returnValue;
        }



    }
}
