using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AnimalHouseEntities;

namespace AnimalHouseUI
{
    public class ErrorManager
    {
        private ErrorManager() { }

        private static ErrorManager errorManager = null;

        public static ErrorManager Instance()
        {
            if (errorManager == null)
            {
                errorManager = new ErrorManager();
            }
            return errorManager;
        }

        public string GetErrorMessage(Exception exception)
        {
            string errorMessage = "";

            if (exception is NoItemsFoundException)
            {
                errorMessage = Localization.ErrorMessages.NoItemsFound + GetErrorMessage(exception.InnerException);
            }
            //peders
            else if (exception is NoCustomerFoundException)
            {
                errorMessage = Localization.ErrorMessages.NoCustomerFound;
            }
            else if (exception is CustomerNotUpdated)
            {
                errorMessage=Localization.ErrorMessages.CustomerNotUpdated;
            }
            else if (exception is SqlException)
            {
                switch (((SqlException)exception).Number)
                {
                    case -1:
                    case -2:
                    case 2:
                    case 53:
                        errorMessage = Localization.ErrorMessages.NetworkError;

                        break;
                    default:
                        errorMessage = Localization.ErrorMessages.DefaultDatabaseError;
                        break;
                }
            }

            return errorMessage;
        }
    }
}
