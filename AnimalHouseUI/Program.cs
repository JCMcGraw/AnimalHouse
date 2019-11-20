using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouseEntities;

namespace AnimalHouseUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerForm());
            Application.Run(new TreatmentBooking());
            Application.Run(new AnimalForm(new Customer(1, "Børge", "Hundevej 8", "12345", "hund@hund.dk", true, "")));
        }
    }
}
