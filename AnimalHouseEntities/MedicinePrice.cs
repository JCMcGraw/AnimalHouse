using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class MedicinePrice
    {
        
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public MedicinePrice(string name, decimal price)
        {
           
            this.Name = name;
            this.Price = price;

        }
      
    }
}
