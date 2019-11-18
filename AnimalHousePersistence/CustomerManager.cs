using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AnimalHouseEntities;



namespace AnimalHousePersistence
{
    public class CustomerManager : ICustomerManager
    {
        public string CreateCustomer(string phone, string name, string address, string email)
        {
            SqlConnection con = new SqlConnection(Utility.connectionString);

            string query = Utility.ReadSQLQueryFromFile("CreateCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

             sQLQuery.AddParameter("@phone", phone.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@name", name.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@address", address.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@email", email.ToString(), SqlDbType.VarChar);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code==0)
            {
                return "Kunde oprettet";
            }
            else
            {
                return sQLQueryResult.message.ToString();

            }

           
        }

        public string UpdateCustomer(string phone, string name, string address, string email)
        {
            SqlConnection con = new SqlConnection(Utility.connectionString);

            string query = Utility.ReadSQLQueryFromFile("UpdateCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@phone", phone.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@name", name.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@address", address.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@email", email.ToString(), SqlDbType.VarChar);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            
                  if (sQLQueryResult.code == 0)
                {
                    return "Kunde rettet";
                }
                else
                {
                    return sQLQueryResult.message.ToString();

                }

        }
        public string DeleteCustomer(string phone)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@phone", phone.ToString(), SqlDbType.VarChar);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                return "Kunde gjort inaktiv";
            }
            else
            {
                return sQLQueryResult.message.ToString();

            }

        }

        public Customer GetCustomer(string phone)
        {
            //Jeg kan ikke få det her fuck til at virke!

            string query = Utility.ReadSQLQueryFromFile("GetCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@phone", phone.ToString(), SqlDbType.VarChar);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            DataRow dataRow = sQLQueryResult.dataTable.Rows[0];

            Customer customer = new Customer((int)dataRow["CustomerID"],(string)dataRow["Name"], (string)dataRow["Adress"], (string)dataRow["Phone"],(string)dataRow["Email"], (bool)dataRow["Active"]);

            return customer;


          //  if (sQLQueryResult.code == 0)
            {
                //read datatable

               // return sQLQueryResult.dataTable;



            }

            //if (sQLQueryResult.code==1)
            //{
            //    return "noget gik galt";
            //}
            //else
            //{
            //    return "noget gik helt galt";
            //}


        }
    }
}
