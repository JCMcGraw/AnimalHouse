using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace AnimalHousePersistence
{
    public static class SQLDatabaseConnector
    {
        //method to query database for single query
        static public SQLQueryResult QueryDatabase(SQLQuery sQLQuery)
        {
            try
            {
                //initialize new DataTable
                DataTable dataTable = new DataTable();

                //start transaction scope
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    //initialize new SqlConnection with connectionstring from Utility Class
                    using (SqlConnection connection = new SqlConnection(Utility.connectionString))
                    {
                        //open connection
                        connection.Open();

                        //initialize SqlCommand
                        using (SqlCommand command = new SqlCommand(sQLQuery.query, connection))
                        {
                            //add parameters to query if needed 
                            foreach (SQLParameter sqlParameter in sQLQuery.sQLParameters)
                            {
                                if (sqlParameter.parameterValue == null)
                                {
                                    command.Parameters.Add(sqlParameter.parameterName, sqlParameter.dataType).Value = DBNull.Value;
                                }
                                else
                                {
                                    command.Parameters.Add(sqlParameter.parameterName, sqlParameter.dataType).Value = sqlParameter.parameterValue;
                                }
                            }

                            //execute sql to server and fill dataTable with returned result
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                            sqlDataAdapter.Fill(dataTable);
                        }
                    }

                    //complete and commit transaction
                    transactionScope.Complete();
                }
                return new SQLQueryResult(dataTable, 0, null);
            }
            catch (Exception e)
            {
                string test = e.GetType().ToString();
                //return empty datatable and error code + exception if there were any issues
                return new SQLQueryResult( new DataTable(), 1, e);
            }
        }

        //method to open connection to database
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(Utility.connectionString);
            connection.Open();

            return connection;
        }

        //method to query database from existing connection
        static public SQLQueryResult QueryDatabase(SQLQuery sQLQuery, SqlConnection connection)
        {

            try
            {
                //initialize new DataTable
                DataTable dataTable = new DataTable();

                //initialize SqlCommand
                using (SqlCommand command = new SqlCommand(sQLQuery.query, connection))
                {
                    //add parameters to query if needed 
                    foreach (SQLParameter sqlParameter in sQLQuery.sQLParameters)
                    {
                        if (sqlParameter.parameterValue == null)
                        {
                            command.Parameters.Add(sqlParameter.parameterName, sqlParameter.dataType).Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.Add(sqlParameter.parameterName, sqlParameter.dataType).Value = sqlParameter.parameterValue;
                        }

                    }
                    //execute sql to server and fill dataTable with returned result
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                    sqlDataAdapter.Fill(dataTable);
                }

                return new SQLQueryResult(dataTable, 0, null);
            }
            catch (Exception e)
            {
                //return empty datatable and error code + exception if there were any issues
                return new SQLQueryResult(new DataTable(), 1, e);
            }
        }
    }
}
