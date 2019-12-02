using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouse
{
    public class ErrorController
    {
        private static ErrorController instance;

        private ErrorController() { }

        public static ErrorController Instance()
        {
            if (instance == null)
            {
                instance = new ErrorController();
            }

            return instance;
        }

        IErrorManager errorManager = new ErrorManager();

        public string GetErrorMessage(Exception exception)
        {
            string errorMessage = errorManager.GetErrorMessage(exception);
            return errorMessage;
        }
    }
}
