using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AnimalHouseEntities;





namespace AnimalHousePersistence
{
    public interface ICustomerManager
    {

       Customer  CreateCustomer(Customer customer);
        string UpdateCustomer(Customer customer);
        string DeleteCustomer(Customer customer);
        Customer GetCustomer(string phone);
        void CreateBusinessCustomer(BusinessCustomer businessCustomer);
        void CreatePrivateCustomer(PrivateCustomer privateCustomer);
        string UndeleteCustomer(Customer customer);
        int GetBusinessCustomerCVR(Customer customer);
        bool CheckUniquePhone(string phone);

    }
}
