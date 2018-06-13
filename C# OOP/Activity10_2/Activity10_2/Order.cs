using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace Activity10_2
{
    class Order
    {
        string _connString = "Data Source=406RP12-LT\\MICHAELSQL;Initial Catalog=WideWorldImporters;Integrated Security=True";

        public DataSet GetData()
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(_connString))
            {               
                using (SqlCommand orderCommand = new SqlCommand())
                {
                    orderCommand.Connection = conn;
                    orderCommand.CommandText = "select OrderID, SalespersonPersonID from sales.Orders";

                    using (SqlDataAdapter orderAdapter = new SqlDataAdapter())
                    {
                        orderAdapter.SelectCommand = orderCommand;
                        orderAdapter.Fill(ds, "Orders");
                    }

                }

                using (SqlCommand personCommand = new SqlCommand())
                {
                    personCommand.Connection = conn;
                    personCommand.CommandText = "select PersonID, FullName from application.People";

                    using (SqlDataAdapter peopleAdapter = new SqlDataAdapter())
                    {
                        peopleAdapter.SelectCommand = personCommand;
                        peopleAdapter.Fill(ds, "People");
                    }
                }

            }


            DataColumn ordersSalespersonPersonID = ds.Tables["Orders"].Columns["OrderID"];
            DataColumn peoplePersonID = ds.Tables["People"].Columns["PersonID"];
            DataRelation ordersPeopleRelation = new DataRelation("OrdersToPeople", ordersSalespersonPersonID, peoplePersonID);
            ds.Relations.Add(ordersPeopleRelation);

            return ds;
        }

    }
}
