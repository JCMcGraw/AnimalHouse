using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class BusinessCustomer : Customer
    {
        public int BusinesscustomerID { get; private set; }

        public int cvr { get; private set; }

        //constructor UDEN customerID, MED cvr
        public BusinessCustomer(int cvr, string name, string address, string phone, string email, bool active) : base(name, address, phone, email, active)
        {
            this.cvr = cvr;
        }

        //constructor MED customerID, MED cvr
        public BusinessCustomer(int customerID, int cvr, string name, string address, string phone, string email, bool active) : base(customerID, name, address, phone, email, active)
        {
            {
                this.BusinesscustomerID = customerID;
                this.cvr = cvr;
            }
        }
    }
}
