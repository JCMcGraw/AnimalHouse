﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Sale
    {
        public int saleID { get; private set; }
        public List<SaleLineItem> saleLineItems { get; private set; }
        public Customer customer { get; private set; }
        public DateTime salesDay { get; private set; }

        public Sale(int saleID, Customer customer, DateTime salesDay)
        {
            this.saleID = saleID;
            this.customer = customer;
            this.salesDay = salesDay;
            saleLineItems = new List<SaleLineItem>();
        }

        public Sale(Customer customer, DateTime salesDay)
        {
            this.customer = customer;
            this.salesDay = salesDay;
            saleLineItems = new List<SaleLineItem>();
        }

        public void UpdateSaleID(int saleID)
        {
            this.saleID = saleID;
        }

        public void AddSaleLineItem(SaleLineItem saleLineItem)
        {
            saleLineItems.Add(saleLineItem);
        }

        public void SetCustomer(Customer customer)
        {
            this.customer = customer;
        }

        public void DeleteSaleLineItem(SaleLineItem saleLineItem)
        {
            for(int i = 0; i < saleLineItems.Count; i++)
            {
                if (saleLineItems[i].saleLineItemID == saleLineItem.saleLineItemID)
                {
                    saleLineItems.RemoveAt(i);
                    break;
                }
            }
        }

        public decimal Price(decimal price, int amount)
        {
            decimal total = price * amount;
            return Math.Round(total, 2);
        }

        public decimal Moms(decimal totalPrice)
        {
            decimal momsPrice = (totalPrice * 1.25m) - totalPrice;
            return Math.Round(momsPrice, 2);
        }

        public decimal TotalPriceInkMoms(decimal price, decimal momsPrice)
        {
            decimal totalPriceInkMoms = price + momsPrice;
            return Math.Round(totalPriceInkMoms, 2);
        }
    }
}
