using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHousePersistence
{
    public interface IErrorManager
    {
        string GetErrorMessage(Exception exception);
    }
}
