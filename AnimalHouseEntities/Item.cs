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

        public decimal costPrice { get; private set; }

        public bool isPrescription { get; private set; }

        public bool isTreatment { get; private set; }

        public bool active { get; private set; }

        //public Treatment treatment { get; private set; }

        //public Prescription prescription { get; private set; }

        public Item(int itemID, string name, int amount, decimal price, decimal costPrice, bool isPrescription, bool isTreatment, bool active)
        {
            this.itemID = itemID;
            this.name = name;
            this.amount = amount;
            this.price = price;
            this.costPrice = costPrice;
            this.isPrescription = isPrescription;
            this.isTreatment = isTreatment;
            this.active = active;
          //  this.treatment = treatment;
            //this.prescription = prescription;
        }

        public override string ToString()
        {
            return $"{name}\t{price.ToString("N2")}\t{amount}";
        }

        public decimal GetTotalStockValue()
        {
            return costPrice * amount;
        }
        
    }
}
