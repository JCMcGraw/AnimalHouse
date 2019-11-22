using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnimalHousePersistence
{
    public class SQLQueryResult
    {
        public DataTable dataTable { get; private set; }
        public int code { get; private set; }
        //public string message { get; private set; }
        public Exception exception { get; private set; }

        public SQLQueryResult(DataTable dataTable, int code, Exception exception)
        {
            this.dataTable = dataTable;
            this.code = code;
            //this.message = message;
            this.exception = exception;
        }
    }
}
