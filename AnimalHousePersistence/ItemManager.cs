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
        public void UpdateMedicinPrice(int adapterSelector )
        //public string UpdateMedicinPrice(MedicinePrice medicinePrice)
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

            List<MedicinePrice> medicinePrices = medicinPriceAdapter.GetMedicinePrice();

            for(int i = 0; i <medicinePrices.Count;i++)
            {
                MedicinePrice medicinePrice = medicinePrices[i]; 


                string query = Utility.ReadSQLQueryFromFile("UpdateMedicinPrice.txt");

                SQLQuery sQLQuery = new SQLQuery(query);

                sQLQuery.AddParameter("@name", medicinePrice.Name.ToString(), SqlDbType.VarChar);
                sQLQuery.AddParameter("@costprice", medicinePrice.Price.ToString(), SqlDbType.Decimal);



                SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);
            }
           


       



            //if (sQLQueryResult.code == 0)
            //{
            //    return "ok";
            //}
            //else
            //{
            //    return sQLQueryResult.exception.Message.ToString();

            //}
            //return "ok";

        }
        public string GetLastUpdate(Item item)
        {
            string query = Utility.ReadSQLQueryFromFile("GetLastUpdate.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@CostPrice", item.costPrice.ToString(), SqlDbType.Decimal);



            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);



            if (sQLQueryResult.code == 0)
            {
                return "Prisen var sidst opdateret den...";
            }
            else
            {
                return sQLQueryResult.exception.Message.ToString();

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
