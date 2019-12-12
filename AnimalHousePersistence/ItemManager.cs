using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    class ItemManager
    {
        public string UpdateMedicinPrice(Item item)
        {
            string query = Utility.ReadSQLQueryFromFile("UpdateMedicinPrice.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@CostPrice", item.costPrice.ToString(), SqlDbType.Decimal);
         


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);



            if (sQLQueryResult.code == 0)
            {
                return "Priser opdateret";
            }
            else
            {
                return sQLQueryResult.exception.Message.ToString();

            }


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
    }
}
