using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
   public class ItemManager: IItemManager
   {
        public void UpdateMedicinePrice(int adapterSelector)
        {
            IMedicinePriceAdapter medicinPriceAdapter;
            if (adapterSelector == 1)
            {
                medicinPriceAdapter = new MedicinePriceAdapter1();
            }
            else
            {
                medicinPriceAdapter = new MedicinePriceAdapter2();
            }
            DateTime UpdateTime = GetLastUpdate();

            List<MedicinePrice> medicinePrices = medicinPriceAdapter.GetMedicinePrice();
            if(medicinePrices[0].date > UpdateTime)
            {
                for (int i = 0; i < medicinePrices.Count; i++)
                {
                    MedicinePrice medicinePrice = medicinePrices[i];

                    string query = Utility.ReadSQLQueryFromFile("UpdateMedicinCostPrice.txt");

                    SQLQuery sQLQuery = new SQLQuery(query);

                    sQLQuery.AddParameter("@name", medicinePrice.name.ToString(), SqlDbType.VarChar);
                    sQLQuery.AddParameter("@costprice", medicinePrice.price.ToString(), SqlDbType.Decimal);

                    SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);
                }
                UpdateMedicinePriceDate(medicinePrices[0]);
            }
        }
        public string UpdateMedicinePriceDate(MedicinePrice medicinePrice)
        {
            string query = Utility.ReadSQLQueryFromFile("UpdateMedicinPriceDate.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@newdate",medicinePrice.date.ToString(), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                return "ok";
            }
            else
            {
                throw new DateNotUpdated("", sQLQueryResult.exception);
            }





        }

        public DateTime GetLastUpdate()
        {
            string query = Utility.ReadSQLQueryFromFile("GetLastUpdate.txt");

            SQLQuery sQLQuery = new SQLQuery(query);



            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);



            if (sQLQueryResult.code == 0)
            {
                return (DateTime) sQLQueryResult.dataTable.Rows[0]["UpdateTime"];
            }
            else
            {
                throw new DateNotFound("", sQLQueryResult.exception);

            }


        }

        public List<Item> GetAllActiveItems()
        {
            string query = Utility.ReadSQLQueryFromFile("GetAllActiveItems.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {

                List<Item> items = GetListOfItemsFromDatatable(sQLQueryResult.dataTable);
                if (items.Count == 0) { throw new NoItemsFoundException("1"); }
                return items;
            }
            else
            {
                throw new NoItemsFoundException("", sQLQueryResult.exception);
            }
        }

        private List<Item> GetListOfItemsFromDatatable(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dataRow in dataTable.Rows)
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
            decimal costPrice = (decimal)dataRow["CostPrice"];
            int amount = (int)dataRow["Amount"];
            bool prescription = (bool)dataRow["Prescription"];
            bool treatment = (bool)dataRow["Treatment"];
            bool active = (bool)dataRow["Active"];

            Item item = ItemFactory.Instance().CreateItem(itemID, name, amount, price, costPrice, prescription, treatment, active);
            return item;
        }
   }
}
