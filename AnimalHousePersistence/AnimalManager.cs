using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnimalHousePersistence
{
    class AnimalManager
    {
        public void GetAnimal(int animalID)
        {
            string query = Utility.ReadSQLQueryFromFile("GetAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalid", animalID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                //read datatable
            }
            else
            {

            }
        }
    }
}
