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
        public Customer CreateCustomer(Customer customer)
        {
            SqlConnection con = new SqlConnection(Utility.connectionString);

            string query = Utility.ReadSQLQueryFromFile("CreateCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

          

            sQLQuery.AddParameter("@phone", customer.phone.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@name", customer.name.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@address",customer.address.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@email",customer.email.ToString(), SqlDbType.VarChar);
            
            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);
            
            if(sQLQueryResult.code != 0)
            {
                throw new Exception(sQLQueryResult.exception.Message, sQLQueryResult.exception);
            }

            int customerID = (int)sQLQueryResult.dataTable.Rows[0]["CustomerID"];

            customer.UpdateID(customerID);
            

            if (customer.GetType()==typeof(BusinessCustomer))

            {
             //der laves en BusinessCustomer som castes til customer

                BusinessCustomer businessCustomer = (BusinessCustomer)customer;
                CreateBusinessCustomer(businessCustomer);
                

            }

            if (customer.GetType() == typeof(PrivateCustomer))

            {
                //der laves en PrivateCustomer som castes til customer
                PrivateCustomer privateCustomer = (PrivateCustomer)customer;
                CreatePrivateCustomer(privateCustomer);
            }
                return customer;

        }

        public void CreateBusinessCustomer(BusinessCustomer businessCustomer)

        {

            SqlConnection con = new SqlConnection(Utility.connectionString);

            string query = Utility.ReadSQLQueryFromFile("CreateBusinessCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);
            
            sQLQuery.AddParameter("@cvr", businessCustomer.cvr.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@businesscustomerID", businessCustomer.BusinesscustomerID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);



        }

        public void CreatePrivateCustomer(PrivateCustomer privateCustomer)
        {
            string query = Utility.ReadSQLQueryFromFile("CreatePrivateCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@privatecustomerID", privateCustomer.PrivatecustomerID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);
        }

        public string UpdateCustomer(Customer customer)
        {
            
            SqlConnection con = new SqlConnection(Utility.connectionString);

            string query = Utility.ReadSQLQueryFromFile("UpdateCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@phone",customer.phone.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@name", customer.name.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@address",customer.address.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@email",customer.email.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@customerID",customer.customerID.ToString(), SqlDbType.VarChar);


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            
                  if (sQLQueryResult.code == 0)
                {
                return "Kunde rettet";
                }
                else
                {
                    return sQLQueryResult.exception.Message.ToString();

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
                return sQLQueryResult.exception.Message.ToString();

            }

        }

        public string UndeleteCustomer(Customer customer)
        {
            string query = Utility.ReadSQLQueryFromFile("UndeleteCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            //af en eller anden grund virker det her fint med varchars og strings
            sQLQuery.AddParameter("@customerID", customer.customerID.ToString(), SqlDbType.VarChar);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                return "Kunde gjort aktiv";
            }
            else
            {
                return sQLQueryResult.exception.Message.ToString();

            }

        }

        public Customer GetCustomer(string phone)
        {
         

            string query = Utility.ReadSQLQueryFromFile("GetCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@phone", phone, SqlDbType.VarChar);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            DataRow dataRow = sQLQueryResult.dataTable.Rows[0];

            Customer customer = new Customer((int)dataRow["CustomerID"],(string)dataRow["Name"], (string)dataRow["Adress"], (string)dataRow["Phone"],(string)dataRow["Email"], (bool)dataRow["Active"]);

            return customer;


          
        }
    }
}
