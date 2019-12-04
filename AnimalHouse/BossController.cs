using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalHouse
{
    public class BossController
    {
        private BossController() { }

        private static BossController bossController = null;

        public static BossController Instance()
        {
            if (bossController == null)
            {
                bossController = new BossController();
            }
            return bossController;
        }

        public CustomerController customerController
        {
            get
            {
                return CustomerController.Instance;
            }
        }

        public TreatmentController treatmentController
        {
            get
            {
                return TreatmentController.Instance();
            }
        }
        public AnimalController animalController
        {
            get
            {
                return AnimalController.Instance();
            }

        }

        public SaleController saleController
        {
            get
            {
                return SaleController.Instance();
            }

        }

        public EmployeeController employeeController
        {
            get
            {
                return EmployeeController.Instance();
            }
        }
    }
}

