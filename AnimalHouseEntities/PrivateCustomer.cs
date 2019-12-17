using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class PrivateCustomer : Customer
    {
        public int PrivatecustomerID { get; private set; }

        //Construtor MED privatecustomerID
        public PrivateCustomer(int customerID, string name, string address, string phone, string email, bool active) : base(customerID, name, address, phone, email, active)
        {
            this.PrivatecustomerID = customerID;
        }

        //Constructor UDEN PrivatecustomerID
        public PrivateCustomer(string name, string address, string phone, string email, bool active) : base(name, address, phone, email, active)
        {
            
        }
    }
}
