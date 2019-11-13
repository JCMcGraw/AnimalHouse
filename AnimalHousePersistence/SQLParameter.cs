using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnimalHousePersistence
{
    public class SQLParameter
    {
        public string parameterName { get; private set; }
        public string parameterValue { get; private set; }
        public SqlDbType dataType { get; private set; }

        public SQLParameter(string parameterName, string parameterValue, SqlDbType dataType)
        {
            this.parameterName = parameterName;
            this.parameterValue = parameterValue;
            this.dataType = dataType;
        }
    }
}
