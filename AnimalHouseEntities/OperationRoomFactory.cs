using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class OperationRoomFactory
    {
        //SingleTon Mønster
        private static OperationRoomFactory instance;

        private OperationRoomFactory() { }

        public static OperationRoomFactory Instance()
        {
            if (instance == null)
            {
                instance = new OperationRoomFactory();
            }

            return instance;
        }

        //Laver obj af OperationRoom
        public OperationRoom CreateOperationRoom(int operationRoomID)
        {
            return new OperationRoom(operationRoomID);
        }
    }
}
