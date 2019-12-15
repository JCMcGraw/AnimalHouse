using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class MedicinePrice
    {
        public string name { get; private set; }

        public decimal price { get; private set; }

        public MedicinePrice(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
