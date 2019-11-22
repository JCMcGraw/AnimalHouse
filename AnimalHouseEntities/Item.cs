using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Item
    {
        public int itemID { get; private set; }
        public string name { get; private set; }
        public int amount { get; private set; }
        public decimal price { get; private set; }
        public bool prescription { get; private set; }
        public bool treatment { get; private set; }
        public bool active { get; private set; }

        public Item(int itemID, string name, int amount, decimal price, bool prescription, bool treatment, bool active)
        {
            this.itemID = itemID;
            this.name = name;
            this.amount = amount;
            this.price = price;
            this.prescription = prescription;
            this.treatment = treatment;
            this.active = active;
        }
    }
}
