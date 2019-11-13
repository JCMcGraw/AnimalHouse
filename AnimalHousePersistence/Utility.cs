using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AnimalHousePersistence
{
    static class Utility
    {
        public static string connectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "den1.mssql7.gear.host";
                builder.UserID = "animalhouse";
                builder.Password = "Se57-FxX!L6G";
                builder.InitialCatalog = "animalhouse";

                return builder.ConnectionString;
            }
            private set
            {
                connectionString = value;
            }
        }
    }
}
