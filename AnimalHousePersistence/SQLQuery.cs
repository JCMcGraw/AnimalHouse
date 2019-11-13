using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnimalHousePersistence
{
    public class SQLQuery
    {
        public string query { get; private set; }
        public List<SQLParameter> sQLParameters;

        public SQLQuery(string query)
        {
            this.query = query;
            sQLParameters = new List<SQLParameter>();
        }

        public void AddParameter(string parameterName, string parameterValue, SqlDbType dataType)
        {
            SQLParameter sQLParameter = new SQLParameter(parameterName, parameterValue, dataType);
            sQLParameters.Add(sQLParameter);
        }
    }
}
