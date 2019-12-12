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
            string errorMessage = "Der opstod en fejl i systemet. Kontakt din systemadministrator";

            if (exception == null)
            {
                return "";
            }
            else if (exception is NoItemsFoundException)
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
            else if (exception is CantDeleteException)
                {
                errorMessage = Localization.ErrorMessages.CantDeleteException;

                }
            else if (exception is CantCreatePrescription)
            {
                errorMessage = Localization.ErrorMessages.CantCreatePrescription;            }

            else if (exception is CantCreateCustomer)
            {
                errorMessage = Localization.ErrorMessages.CantCreateCustomer;
            }
            else if (exception is CantCreatePrescription)
            {
                errorMessage = Localization.ErrorMessages.CantCreatePrescription;
            }
            else if (exception is NoRemindersFoundException)
            {
                if (exception.Message == "1")
                {
                    errorMessage = Localization.ErrorMessages.NoRemindersFound + GetErrorMessage(exception.InnerException);
                }
                else
                {
                    errorMessage = Localization.ErrorMessages.NoRemindersFound;
                }
            }
            else if (exception is TreatmentNotCreatedException)
            {
                errorMessage = Localization.ErrorMessages.CantCreateTreatment + GetErrorMessage(exception.InnerException); ;
            }
            else if (exception is NoEmployeesFoundException)
            {
                errorMessage = Localization.ErrorMessages.NoEmployeesFound + GetErrorMessage(exception.InnerException); ;
            }
            else if (exception is NoTreatmentTypesFoundException)
            {
                errorMessage = Localization.ErrorMessages.NoTreatmentTypesFound + GetErrorMessage(exception.InnerException); ;
            }
            else if (exception is AnimalNotEditedException)
            {
                errorMessage = Localization.ErrorMessages.AnimalNotEdited + GetErrorMessage(exception.InnerException); ;
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
