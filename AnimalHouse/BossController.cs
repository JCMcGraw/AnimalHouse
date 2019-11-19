﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalHouse
{
    public class BossController
    {

        private BossController()
        { }
        private static BossController bossController = null;
        public static BossController instance()
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
             return   CustomerController.instance;
            }
        }

        public TreatmentController treatmentController
        {
            get
            {
                return TreatmentController.instance();
            }
        }


    }
}
