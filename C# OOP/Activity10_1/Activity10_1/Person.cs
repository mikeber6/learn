using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Activity10_1
{
    class Person
    {
        string _connString = "Data Source=406RP12-LT\\MICHAELSQL;Initial Catalog=WideWorldImporters;Integrated Security=True";

        public int CountPeople()
        {            
            using (SqlConnection peopleConnection = new SqlConnection(_connString))
            {
                using (SqlCommand peopleCommand = new SqlCommand())
                {
                    peopleCommand.Connection = peopleConnection;
                    peopleCommand.CommandText = "select count(PersonID) from Application.People";                 
                    peopleConnection.Open();
                    return (int)peopleCommand.ExecuteScalar();
                }
            }
        }

        public List<string> GetPersonList()
        {
            List<string> nameList = new List<string>();
            using (SqlConnection peopleConnection = new SqlConnection(_connString))
            {
                using (SqlCommand peopleCommand = new SqlCommand())
                {
                    peopleCommand.Connection = peopleConnection;
                    peopleCommand.CommandText = "select FullName from Application.People";
                    peopleConnection.Open();

                    using (SqlDataReader peopleDataReader = peopleCommand.ExecuteReader())
                    {
                        while (peopleDataReader.Read())
                        {
                            nameList.Add(peopleDataReader.GetString(0));
                        }
                        return nameList;
                    }
                }
            }
        }

        public List<string> GetPersonList(string nameSearchText)
        {
            List<string> nameList = new List<string>();
            using (SqlConnection peopleConnection = new SqlConnection(_connString))
            {
                using (SqlCommand peopleCommand = new SqlCommand())
                {
                    peopleCommand.Connection = peopleConnection;
                    peopleCommand.CommandType = CommandType.StoredProcedure;
                    peopleCommand.CommandText = "website.simplesearchforpeople";

                    SqlParameter nameParameter = new SqlParameter();
                    nameParameter.ParameterName = "@searchtext";
                    nameParameter.Direction = ParameterDirection.Input;
                    nameParameter.Value = nameSearchText;
                    peopleCommand.Parameters.Add(nameParameter);                   
                                        
                    peopleConnection.Open();
                    
                    using (SqlDataReader peopleDataReader = peopleCommand.ExecuteReader())
                    {                        
                        while (peopleDataReader.Read())
                        {
                            nameList.Add(peopleDataReader.GetString(0));
                        }
                        return nameList;
                    }
                }
            }


        }



    }
}
