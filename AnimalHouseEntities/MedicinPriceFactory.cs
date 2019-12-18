using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class MedicinPriceFactory
    {
        //SingleTon Mønster
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

        //Laver Obj af MedicinPrice
        public MedicinePrice CreateMedicinPrice(string name, decimal price, DateTime date)
        {
            return new MedicinePrice(name, price, date);
        }
    }
}
