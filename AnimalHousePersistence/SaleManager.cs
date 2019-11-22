using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using System.Data;
using System.Data.SqlClient;

namespace AnimalHousePersistence
{
    public class SaleManager : ISaleManager
    {

        public List<Item> GetAllActiveItems()
        {
            string query = Utility.ReadSQLQueryFromFile("GetAllActiveItems.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                List<Item> items = GetListOfItemsFromDatatable(sQLQueryResult.dataTable);
                return items;
            }
            else
            {
                return new List<Item>();
            }
        }

        private List<Item> GetListOfItemsFromDatatable(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach(DataRow dataRow in dataTable.Rows)
            {
                Item item = GetItemFromDataRow(dataRow);
                items.Add(item);
            }

            return items;
        }

        private Item GetItemFromDataRow(DataRow dataRow)
        {
            int itemID = (int)dataRow["ItemID"];
            string name = (string)dataRow["Name"];
            decimal price = (decimal)dataRow["Price"];
            int amount = (int)dataRow["Amount"];
            bool prescription = (bool)dataRow["Prescription"];
            bool treatment = (bool)dataRow["Treatment"];
            bool active = (bool)dataRow["Active"];

            Item item = ItemFactory.Instance().CreateItem(itemID, name, amount, price, prescription, treatment, active);
            return item;
        }

        public Sale CreateSale(Sale sale)
        {
            SqlTransaction sqlTransaction;
            using (SqlConnection sqlConnection = SQLDatabaseConnector.BeginTransaction(out sqlTransaction))
            {
                string saleQuery = Utility.ReadSQLQueryFromFile("CreateSale.txt");

                SQLQuery sQLQuery = new SQLQuery(saleQuery);

                string customerID;
                if (sale.customer == null)
                { customerID = null; }
                else
                { customerID = sale.customer.customerID.ToString(); }

                sQLQuery.AddParameter("@customerid", customerID, SqlDbType.Int);

                SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery, sqlConnection, sqlTransaction);

                if (sQLQueryResult.code != 0 || sQLQueryResult.dataTable.Rows.Count == 0)
                {
                    sqlTransaction.Rollback();
                    return sale;
                }
                else
                {
                    int saleID = (int)sQLQueryResult.dataTable.Rows[0]["SaleID"];
                    sale.UpdateSaleID(saleID);
                }
                
                string saleLineItemquery = Utility.ReadSQLQueryFromFile("CreateSaleLineItem.txt");
                string updateItemAmountQuery = Utility.ReadSQLQueryFromFile("UpdateItemAmount.txt");
                foreach (SaleLineItem saleLineItem in sale.saleLineItems)
                {
                    sQLQuery = new SQLQuery(saleLineItemquery);
                    sQLQuery.AddParameter("@amount", saleLineItem.amount.ToString(), SqlDbType.Int);
                    sQLQuery.AddParameter("@price", saleLineItem.price.ToString(), SqlDbType.Decimal);
                    sQLQuery.AddParameter("@saleid", sale.saleID.ToString(), SqlDbType.Int);
                    sQLQuery.AddParameter("@itemid", saleLineItem.item.itemID.ToString(), SqlDbType.Int);

                    sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery, sqlConnection, sqlTransaction);

                    if (sQLQueryResult.code != 0 || sQLQueryResult.dataTable.Rows.Count == 0)
                    {
                        sqlTransaction.Rollback();
                        return sale;
                    }
                    else
                    {
                        int saleLineItemID = (int)sQLQueryResult.dataTable.Rows[0]["SaleLineItemsID"];
                        saleLineItem.UpdateSaleLineItemID(saleLineItemID);

                        SQLQuery updateAmountSQLQuery = new SQLQuery(updateItemAmountQuery);
                        updateAmountSQLQuery.AddParameter("@decreaseamount", saleLineItem.amount.ToString(), SqlDbType.Int);
                        updateAmountSQLQuery.AddParameter("@itemid", saleLineItem.item.itemID.ToString(), SqlDbType.Int);

                        sQLQueryResult = SQLDatabaseConnector.QueryDatabase(updateAmountSQLQuery, sqlConnection, sqlTransaction);

                        if (sQLQueryResult.code != 0)
                        {
                            sqlTransaction.Rollback();
                            return sale;
                        }
                    }
                }

                sqlTransaction.Commit();
            }

            return sale;
        }


        public string DeleteSale(Sale sale)
        {
            throw new NotImplementedException();
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

            throw new NotImplementedException();
        }

        private List<Sale> GetSalesFromDataTable(DataTable dataTable, Customer customer)
        {
            List<Sale> sales = new List<Sale>();
            Sale sale = null;

            foreach(DataRow dataRow in dataTable.Rows)
            {
                int saleID = (int)dataRow["SaleID"];
                if(sale is null)
                {
                    sale = new Sale(saleID, customer);
                }
                else if(sale.saleID != saleID)
                {
                    sales.Add(sale);
                    sale = new Sale(saleID, customer);
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

            SaleLineItem saleLineItem = SaleLineItemFactory.Instance().CreateSaleLineItem(item, saleLineItemID, amount, price);

            return saleLineItem;
        }


        public string UpdateSale(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
