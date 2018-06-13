using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace OfficeSupplyBLL
{
    class DALEmployee
    {

        public int LogIn(string userName, string password)
        {
            string connString = DALUtility.GetSQLConnection("OSConnection");
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select employeeID from employee where username = @username and password = @password";
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@password", password);

                    int userID;

                    conn.Open();

                    userID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userID > 0)
                    {
                        return userID;
                    }
                    else
                    {
                        return -1;
                    }

                }


            }


        }


    }
}
