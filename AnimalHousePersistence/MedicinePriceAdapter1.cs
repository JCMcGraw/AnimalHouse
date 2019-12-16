using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public class MedicinePriceAdapter1: IMedicinePriceAdapter
    {
        public List<MedicinePrice>GetMedicinePrice()
        {
            List<MedicinePrice> list = new List<MedicinePrice>();

            string[] MedicinPrices = File.ReadAllLines("D:\\Medicin\\medicin1.txt");

            DateTime date;

            for (int i = 2; i < MedicinPrices.Length; i++)
            {
                string[] MedicinList = MedicinPrices[i].Split('?');
                decimal price = Convert.ToDecimal(MedicinList[0]);
                string name = MedicinList[1];
               
                MedicinePrice medicinPrice = new MedicinePrice(name,price);
                list.Add(medicinPrice);
            }
            return list;
        }
    }
}
