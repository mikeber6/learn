using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Activity10_2
{
    class Person
    {
        string _connString = "Data Source=406RP12-LT\\MICHAELSQL;Initial Catalog=WideWorldImporters;Integrated Security=True";

        public DataSet GetData()
        {
            DataSet personSet;

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand selectCommand = new SqlCommand())
                {
                    selectCommand.CommandText = "select personID, fullname, preferredname from application.People ";
                    selectCommand.Connection = conn;

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = selectCommand;
                        personSet = new DataSet();
                        adapter.Fill(personSet, "Person");
                    }
                }

            }
            return personSet;

        }

        public void UpdateData(DataSet changedData)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand updateComm = new SqlCommand())
                {
                    updateComm.CommandText = "update application.people set FullName = @fullName, PreferredName = @preferredName where PersonID = @personID";
                    updateComm.Parameters.Add("@personID", SqlDbType.Int, 10, "PersonID");
                    updateComm.Parameters.Add("@fullName", SqlDbType.VarChar, 50, "FullName");
                    updateComm.Parameters.Add("@preferredName", SqlDbType.VarChar, 50, "PreferredName");

                    updateComm.Connection = conn;

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.UpdateCommand = updateComm;
                        adapter.Update(changedData, "Person");
                    }

                }

            }

        }


    }
}
