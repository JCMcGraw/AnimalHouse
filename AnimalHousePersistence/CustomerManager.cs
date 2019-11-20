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
        public string CreateCustomer(Customer customer)
        {
            SqlConnection con = new SqlConnection(Utility.connectionString);

            string query = Utility.ReadSQLQueryFromFile("CreateCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

          

            sQLQuery.AddParameter("@phone", customer.phone.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@name", customer.name.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@address",customer.address.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@email",customer.email.ToString(), SqlDbType.VarChar);
            

           // sQLQuery.AddParameter("@cvr", customer.cvr.ToString(), SqlDbType.VarChar);

            //Den virker hvis jeg insætter telefonnummeret direkte her, men ikke hvis jeg bruger customer.phone.tostring()

           // Customer tmpcustomer = GetCustomer(999.ToString()); //Skal hente en kunde ud fra dens nummer.


           
            //---Problemet er at den ikke kan læse en kunde op fra databasen før den er helt færdig med at lægge 
            //denne her nedi den.

            //sQLQuery.AddParameter("@customerID", tmpcustomer.customerID.ToString(), SqlDbType.VarChar);
            



            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code==0&&customer.cvr==null)
            {
                return "Kunde oprettet, cvr er null";
            }
            if (sQLQueryResult.code == 0 && customer.cvr != null)
            {
                return "Kunde oprettet, cvr er ikke null";
            }

            else
            {
                return sQLQueryResult.message.ToString();

            }

           
        }

        public string UpdateCustomer(Customer customer)
        {
            

            SqlConnection con = new SqlConnection(Utility.connectionString);

            string query = Utility.ReadSQLQueryFromFile("UpdateCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@phone", customer.phone.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@name", customer.name.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@address", customer.address.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@email", customer.email.ToString(), SqlDbType.VarChar);
            

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
        public string DeleteCustomer(Customer customer)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            //af en eller anden grund virker det her fint med varchars og strings
            sQLQuery.AddParameter("@customerID", customer.customerID.ToString(), SqlDbType.VarChar);

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

            sQLQuery.AddParameter("@phone", phone, SqlDbType.VarChar);

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
