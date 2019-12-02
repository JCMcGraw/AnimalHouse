using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using System.Data.SqlClient;
using System.Resources;
using System.Threading;


namespace AnimalHousePersistence
{
    public class ErrorManager : IErrorManager
    {

        public string GetErrorMessage(Exception exception)
        {
            string errorMessage = "";

            if (exception is NoItemsFoundException)
            {
                errorMessage = Localization.ErrorMessages.NoItemsFound + GetErrorMessage(exception.InnerException);
            }
            //peders
            if(exception is NoCustomerFoundException)
            {
                
            }
            else if (exception is SqlException)
            {
                switch(((SqlException)exception).Number)
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
