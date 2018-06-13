using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace OfficeSupplyBLL
{
    class DALOrder
    {
        public int PlaceOrder(string xmlOrder)
        {
            string connString = DALUtility.GetSQLConnection("OSConnection");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "up_PlaceOrder";
                    SqlParameter inParameter = new SqlParameter();
                    inParameter.ParameterName = "@xmlOrder";
                    inParameter.Value = xmlOrder;
                    inParameter.DbType = DbType.String;
                    inParameter.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(inParameter);

                    SqlParameter returnParameter = new SqlParameter();
                    returnParameter.ParameterName = "@orderid";
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnParameter);

                    int orderNo;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    orderNo = (int)cmd.Parameters["@orderid"].Value;
                    return orderNo;
                }
            }            
        }
    }
}
