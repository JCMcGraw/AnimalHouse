using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AnimalHousePersistence
{
    public static class SQLDatabaseConnector
    {
        static public SQLQueryResult QueryDatabase(SQLQuery sQLQuery)
        {
            try
            {
                //initialize new DataTable
                DataTable dataTable = new DataTable();

                //initialize new SqlConnection with connectionstring from Utility Class
                using (SqlConnection connection = new SqlConnection(Utility.connectionString))
                {
                    //open connection
                    connection.Open();
                    SqlTransaction sqlTransaction = connection.BeginTransaction();

                    try
                    {
                        //initialize SqlCommand
                        using (SqlCommand command = new SqlCommand(sQLQuery.query, connection, sqlTransaction))
                        {

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
                        sqlTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        sqlTransaction.Rollback();
                        return new SQLQueryResult(new DataTable(), 1, e.Message);
                    }
                }

                return new SQLQueryResult(dataTable, 0, "");
            }
            catch (Exception e)
            {
                return new SQLQueryResult( new DataTable(), 2, e.Message);
            }
        }

        public static SqlConnection BeginTransaction(out SqlTransaction sqlTransaction)
        {
            SqlConnection connection = new SqlConnection(Utility.connectionString);
            connection.Open();
            sqlTransaction = connection.BeginTransaction();

            return connection;
        }

        static public SQLQueryResult QueryDatabase(SQLQuery sQLQuery, SqlConnection connection, SqlTransaction sqlTransaction)
        {
                //initialize new DataTable
                DataTable dataTable = new DataTable();

                    try
                    {
                        //initialize SqlCommand
                        using (SqlCommand command = new SqlCommand(sQLQuery.query, connection, sqlTransaction))
                        {

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
                    catch (Exception e)
                    {
                        return new SQLQueryResult(new DataTable(), 1, e.Message);
                    }

                return new SQLQueryResult(dataTable, 0, "");
        }
    }
}
