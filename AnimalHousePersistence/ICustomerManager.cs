using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;





namespace AnimalHousePersistence
{
    public interface ICustomerManager
    {

       string  CreateCustomer(string phone, string name, string address, string email);
        string UpdateCustomer(string phone, string name, string address, string email);
        string DeleteCustomer(string phone);
        DataTable GetCustomer(string phone);

    }
}
