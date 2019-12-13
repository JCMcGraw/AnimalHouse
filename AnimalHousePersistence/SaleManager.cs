using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace AnimalHousePersistence
{
    public class SaleManager : ISaleManager
    {
        //public List<Item> GetAllActiveItems()
        //{
        //        string query = Utility.ReadSQLQueryFromFile("GetAllActiveItems.txt");

        //        SQLQuery sQLQuery = new SQLQuery(query);

        //        SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

        //        if (sQLQueryResult.code == 0)
        //        {

        //            List<Item> items = GetListOfItemsFromDatatable(sQLQueryResult.dataTable);
        //        if (items.Count == 0) { throw new NoItemsFoundException("1"); }
        //            return items;
        //        }
        //        else
        //        {
        //            throw new NoItemsFoundException("", sQLQueryResult.exception);
        //        }
        //}

        //private List<Item> GetListOfItemsFromDatatable(DataTable dataTable)
        //{
        //    List<Item> items = new List<Item>();

        //    foreach(DataRow dataRow in dataTable.Rows)
        //    {
        //        Item item = GetItemFromDataRow(dataRow);
        //        items.Add(item);
        //    }

        //    return items;
        //}

        private Item GetItemFromDataRow(DataRow dataRow)
        {


            int itemID = (int)dataRow["ItemID"];
            string name = (string)dataRow["Name"];
            decimal price = (decimal)dataRow["Price"];
            decimal costPrice = (decimal)dataRow["CostPrice"];
            int amount = (int)dataRow["Amount"];
            bool prescription = (bool)dataRow["Prescription"];
            bool treatment = (bool)dataRow["Treatment"];
            bool active = (bool)dataRow["Active"];

            Item item = ItemFactory.Instance().CreateItem(itemID, name, amount, price, costPrice, prescription, treatment, active);
            return item;
        }

        public Sale CreateSale(Sale sale)
        {
            try
            {
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    using (SqlConnection sqlConnection = SQLDatabaseConnector.OpenConnection())
                    {
                        sale = InsertSale(sale, sqlConnection);
                        sale = InsertSaleLineItemsInSale(sale, sqlConnection);
                    }
                    transactionScope.Complete();
                }
            }
            catch (Exception e)
            {
                
                return sale;
            }

            return sale;
        }

        private Sale InsertSale(Sale sale, SqlConnection connection)
        {
            string saleQuery = Utility.ReadSQLQueryFromFile("CreateSale.txt");

            SQLQuery sQLQuery = new SQLQuery(saleQuery);

            string customerID;
            if (sale.customer == null)
            { customerID = null; }
            else
            { customerID = sale.customer.customerID.ToString(); }

            sQLQuery.AddParameter("@customerid", customerID, SqlDbType.Int);
            sQLQuery.AddParameter("@salesday", sale.salesDay.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery, connection);

            if (sQLQueryResult.code != 0 || sQLQueryResult.dataTable.Rows.Count == 0)
            {
                throw sQLQueryResult.exception;
            }
            else
            {
                int saleID = (int)sQLQueryResult.dataTable.Rows[0]["SaleID"];
                sale.UpdateSaleID(saleID);
            }
            return sale;
        }

        private Sale InsertSaleLineItemsInSale(Sale sale, SqlConnection connection)
        {
            string saleLineItemquery = Utility.ReadSQLQueryFromFile("CreateSaleLineItem.txt");
            string updateItemAmountQuery = Utility.ReadSQLQueryFromFile("UpdateItemAmount.txt");
            foreach (SaleLineItem saleLineItem in sale.saleLineItems)
            {
                SQLQuery sQLQuery = new SQLQuery(saleLineItemquery);
                sQLQuery.AddParameter("@amount", saleLineItem.amount.ToString(), SqlDbType.Int);
                sQLQuery.AddParameter("@price", saleLineItem.price.ToString(), SqlDbType.Decimal);
                sQLQuery.AddParameter("@saleid", sale.saleID.ToString(), SqlDbType.Int);
                sQLQuery.AddParameter("@itemid", saleLineItem.item.itemID.ToString(), SqlDbType.Int);

                SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery, connection);

                if (sQLQueryResult.code != 0 || sQLQueryResult.dataTable.Rows.Count == 0)
                {
                    throw sQLQueryResult.exception;
                }
                else
                {
                    if (saleLineItem.item.isTreatment == false)
                    {
                        int saleLineItemID = (int)sQLQueryResult.dataTable.Rows[0]["SaleLineItemsID"];
                        saleLineItem.UpdateSaleLineItemID(saleLineItemID);

                        SQLQuery updateAmountSQLQuery = new SQLQuery(updateItemAmountQuery);
                        updateAmountSQLQuery.AddParameter("@decreaseamount", saleLineItem.amount.ToString(), SqlDbType.Int);
                        updateAmountSQLQuery.AddParameter("@itemid", saleLineItem.item.itemID.ToString(), SqlDbType.Int);

                        sQLQueryResult = SQLDatabaseConnector.QueryDatabase(updateAmountSQLQuery, connection);

                        if (sQLQueryResult.code != 0)
                        {
                            throw sQLQueryResult.exception;
                        }
                    }
                }
            }
            return sale;
        }


        public string DeleteSale(Sale sale)
        {
            try
            {
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    using (SqlConnection sqlConnection = SQLDatabaseConnector.OpenConnection())
                    {

                        DeleteSaleLineItemsFromSale(sale, sqlConnection);
                        DeleteSale(sale, sqlConnection);
                        
                    }
                    transactionScope.Complete();
                }

            }
            catch (Exception e)
            {
                return "Sale not  deleted";
            }
            return "Sale deleted";
        }

        private void DeleteSaleLineItemsFromSale(Sale sale, SqlConnection connection)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteSaleLineItemsFromSale.txt");
            SQLQuery sQLQuery = new SQLQuery(query);
            sQLQuery.AddParameter("@saleid", sale.saleID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery, connection);

            if (sQLQueryResult.code != 0)
            {
                throw sQLQueryResult.exception;
            }
        }

        private void DeleteSale(Sale sale, SqlConnection connection)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteSale.txt");
            SQLQuery sQLQuery = new SQLQuery(query);
            sQLQuery.AddParameter("@saleid", sale.saleID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery, connection);

            if (sQLQueryResult.code != 0)
            {
                throw sQLQueryResult.exception;
            }
        }

        public List<Sale> GetManySalesByCustomerID(Customer customer)
        {
            List<Sale> sales;

            string query = Utility.ReadSQLQueryFromFile("GetManySalesByCustomerID.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@customerid", customer.customerID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code != 0 || sQLQueryResult.dataTable.Rows.Count == 0)
            {
                return new List<Sale>();
            }
            else
            {
                sales = GetSalesFromDataTable(sQLQueryResult.dataTable, customer);
            }
            return sales;
        }

        private List<Sale> GetSalesFromDataTable(DataTable dataTable, Customer customer)
        {
            List<Sale> sales = new List<Sale>();
            Sale sale = null;

            foreach(DataRow dataRow in dataTable.Rows)
            {
                int saleID = (int)dataRow["SaleID"];
                DateTime salesDay = (DateTime)dataRow["SalesDay"];
                if (sale is null)
                {
                    sale = new Sale(saleID, customer, salesDay);
                }
                else if(sale.saleID != saleID)
                {
                    sales.Add(sale);
                    sale = new Sale(saleID, customer, salesDay);
                }

                SaleLineItem saleLineItem = GetSaleLineItemFromDataRow(dataRow);
                sale.AddSaleLineItem(saleLineItem);

            }
            sales.Add(sale);

            return sales;
        }

        private SaleLineItem GetSaleLineItemFromDataRow(DataRow dataRow)
        {
            Item item = GetItemFromDataRow(dataRow);

            int saleLineItemID = (int)dataRow["SaleLineItemsID"];
            int amount = (int)dataRow["Quantity"];
            decimal price = (decimal)dataRow["SalePrice"];

            SaleLineItem saleLineItem = SaleLineItemFactory.Instance().CreateSaleLineItem(item, saleLineItemID, amount, price, null, null);

            return saleLineItem;
        }


        public string UpdateSale(Sale sale)
        {
            try
            {
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    using (SqlConnection sqlConnection = SQLDatabaseConnector.OpenConnection())
                    {

                        DeleteSaleLineItemsFromSale(sale, sqlConnection);
                        InsertSaleLineItemsInSale(sale, sqlConnection);
                    }
                    transactionScope.Complete();
                }
            }
            catch (Exception e)
            {
                return "Sale not  updated";
            }
            return "Sale updated";
        }
    }
}
