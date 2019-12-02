using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class OperationRoom
    {
        public int operationRoomID { get; private set; }

        public OperationRoom(int operationRoomID)
        {
            this.operationRoomID = operationRoomID;
        }
    }
}
