using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public class MedicinePriceAdapter2: IMedicinePriceAdapter
    {
        public List<MedicinePrice>GetMedicinePrice()
        {
            List<MedicinePrice> list = new List<MedicinePrice>();

            string[] MedicinPrices = File.ReadAllLines("Medicin/medicin2.txt");
            DateTime date = Convert.ToDateTime(MedicinPrices[0]);
            



            for (int i = 2; i < MedicinPrices.Length; i++)
            {
                string[] MedicinList = MedicinPrices[i].Split('?');
                string name = MedicinList[1];
                decimal price = Convert.ToDecimal(MedicinList[0]);

                MedicinePrice medicinPrice = new MedicinePrice(name, price, date);
                list.Add(medicinPrice);
            }
            return list;
        }
    }
}
