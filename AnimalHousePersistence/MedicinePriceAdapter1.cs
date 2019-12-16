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

            DateTime date = Convert.ToDateTime(MedicinPrices[0]);

            for (int i = 2; i < MedicinPrices.Length; i++)
            {
                string[] MedicinList = MedicinPrices[i].Split('_');
                decimal price = Convert.ToDecimal(MedicinList[1]);
                string name = MedicinList[0];
                
                MedicinePrice medicinPrice = new MedicinePrice(name,price,date);
                list.Add(medicinPrice);
            }
            return list;
        }
    }
}
