using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class SaleLineItem
    {
        public Item item { get; private set; }

        public Treatment treatment { get; private set; }

        public Prescription prescription { get; private set; }

        public int saleLineItemID { get; private set; }

        public int amount { get; private set; }

        public decimal price { get; private set; }

        public SaleLineItem(Item item, int saleLineItemID, int amount, decimal price, Treatment treatment, Prescription prescription)
        {
            this.item = item;
            this.saleLineItemID = saleLineItemID;
            this.amount = amount;
            this.price = price;
            this.treatment = treatment;
            this.prescription = prescription;
        }

        public SaleLineItem(Item item, int amount, decimal price, Treatment treatment, Prescription prescription)
        {
            this.item = item;
            this.amount = amount;
            this.price = price;
            this.treatment = treatment;
            this.prescription = prescription;
        }

        public void UpdateSaleLineItemID(int saleLineItemID)
        {
            this.saleLineItemID = saleLineItemID;
        }
    }
}
