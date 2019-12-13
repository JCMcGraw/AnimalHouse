using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    class MedicinPrice
    {
        public DateTime Date { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public MedicinPrice(DateTime date, string name, decimal price)
        {
            this.Date = date;
            this.Name = name;
            this.Price = price;

        }
        public void UpdateMedicin(string name)
        {
            this.Name = name;
        }
    }
}
