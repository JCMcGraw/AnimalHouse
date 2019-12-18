using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AnimalHouseEntities;
using System.Diagnostics;
using System.Windows.Forms;

namespace AnimalHousePersistence
{
    public class MedicinePriceAdapter1: IMedicinePriceAdapter
    {
        public List<MedicinePrice>GetMedicinePrice()
        {
            List<MedicinePrice> list = new List<MedicinePrice>();


            string file = Path.GetDirectoryName(Application.ExecutablePath) + "/Medicine/medicin1.txt";

            string[] MedicinPrices = File.ReadAllLines(file);

            DateTime date = Convert.ToDateTime(MedicinPrices[0]);

            for (int i = 2; i < MedicinPrices.Length; i++)
            {
                string[] MedicinList = MedicinPrices[i].Split('_');
                decimal price = Convert.ToDecimal(MedicinList[1]);
                string name = MedicinList[0];
                
                MedicinePrice medicinPrice = MedicinPriceFactory.Instance().CreateMedicinPrice(name,price,date);
                list.Add(medicinPrice);
            }
            return list;
        }
    }
}
