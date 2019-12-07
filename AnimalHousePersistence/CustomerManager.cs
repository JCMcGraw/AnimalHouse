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

            if (sQLQueryResult.code != 0)
            {
                throw new CantCreateCustomer("", sQLQueryResult.exception);
            }

            int customerID = (int)sQLQueryResult.dataTable.Rows[0]["CustomerID"];
        

            customer.UpdateID(customerID);

            if (customer.GetType() == typeof(BusinessCustomer))

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
            sQLQuery.AddParameter("@businesscustomerID", businessCustomer.customerID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

        }

        public void CreatePrivateCustomer(PrivateCustomer privateCustomer)
        {
            string query = Utility.ReadSQLQueryFromFile("CreatePrivateCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@customerID", privateCustomer.customerID.ToString(), SqlDbType.Int);

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
            sQLQuery.AddParameter("@customerID",customer.customerID.ToString(), SqlDbType.Int);


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            
                  if (sQLQueryResult.code == 0)
                {
                return "Kunde rettet";
                }
                else
                {
                throw new CustomerNotUpdated("", sQLQueryResult.exception);

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
                throw new CantDeleteException("", sQLQueryResult.exception);

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
            Customer customer;

            string query = Utility.ReadSQLQueryFromFile("GetCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@phone", phone, SqlDbType.VarChar);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if(sQLQueryResult.code == 0 && sQLQueryResult.dataTable.Rows.Count > 0)
            {
                DataRow dataRow = sQLQueryResult.dataTable.Rows[0];
                
                customer = CustomerFactory.Instance().CreateCustomer((int)dataRow["CustomerID"], (string)dataRow["Name"], (string)dataRow["Adress"], (string)dataRow["Phone"], (string)dataRow["Email"], (bool)dataRow["Active"], (int)dataRow["cvr"]);

                return customer;
            }
            else
            {
                throw new NoCustomerFoundException("", sQLQueryResult.exception);

            }



        }

        public int GetBusinessCustomerCVR(Customer customer)
        {
            string query = Utility.ReadSQLQueryFromFile("GetBusinesscustomerCVR.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@customerID", customer.customerID.ToString(), SqlDbType.VarChar);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            int cvr;
            try
            {
                DataRow dataRow = sQLQueryResult.dataTable.Rows[0];
                cvr = (int)dataRow["CVR"];
            }
            catch
            {
                 cvr=0;
            }
            return cvr;

        }

        public bool CheckUniquePhone(string phone)
        {
            SqlConnection con = new SqlConnection(Utility.connectionString);

            string query = Utility.ReadSQLQueryFromFile("CheckUniquePhone.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@phone", phone, SqlDbType.VarChar);
            
            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            //hvis nummeret allerede findes sender den false afsted. Den sender altid en false afsted

            if ((int)sQLQueryResult.dataTable.Rows[0]["counter"] == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
