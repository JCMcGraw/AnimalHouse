using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class MedicinPriceFactory
    {
        private static MedicinPriceFactory instance;

        private MedicinPriceFactory() { }

        public static MedicinPriceFactory Instance()
        {
            if (instance == null)
            {
                instance = new MedicinPriceFactory();
            }
            return instance;
        }

        public MedicinePrice CreateMedicinPrice(string name, decimal price)
        {
            return new MedicinePrice(name, price);
        }
    }
}
