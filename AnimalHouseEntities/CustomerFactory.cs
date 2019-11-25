using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnimalHouseEntities
{
    public class CustomerFactory
    {


        private CustomerFactory()
        { }
        private static CustomerFactory customerFactory = null;
        public static CustomerFactory Instance()
        {

            if (customerFactory == null)
            {
                customerFactory = new CustomerFactory();
            }
            return customerFactory;


        }
        
        public Customer CreateCustomer(string name, string address, string phone, string email, bool active, int cvr)
        {
            if (cvr!=0)
            {
                return new BusinessCustomer(cvr, name, address, phone,email, true);

            }
            else
            {
                
                   return new PrivateCustomer(name, address, phone, email, true);
            }
        }
 
            
    //public Customer CreateCustomer()
    //      //public DataTable GetCustomer(string phone)
    //{

    //    return customerManager.GetCustomer(phone);


    //}

    //public string CreateCustomer(string phone, string name, string address, string email)
    //{


    //    return customerManager.CreateCustomer(phone, name, address, email);
    //}

    //public string UpdateCustomer(string phone, string name, string address, string email)
    //{
    //    return customerManager.UpdateCustomer(phone, name, address, email);

    //}

    //public string DeleteCustomer(string phone)
    //{
    //    return customerManager.DeleteCustomer(phone);
    //}
}
}
