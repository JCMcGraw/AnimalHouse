using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using System.Data;

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
                int itemID = (int)dataRow["ItemID"];
                string name = (string)dataRow["Name"];
                decimal price = (decimal)dataRow["Price"];
                int amount = (int)dataRow["Amount"];
                bool prescription = (bool)dataRow["Prescription"];
                bool treatment = (bool)dataRow["Treatment"];
                bool active = (bool)dataRow["Active"];

                Item item = ItemFactory.Instance().CreateItem(itemID, name, amount, price, prescription, treatment, active);
                items.Add(item);
            }

            return items;
        }

        public Sale CreateSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public string DeleteSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetManySalesByCustomerID(Customer customer)
        {
            throw new NotImplementedException();
        }

        public string UpdateSale(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
