using Minal_LiftSystem.Context;
using Minal_LiftSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minal_LiftSystem.States
{
    internal class CloseDoorState_1 : IDoor

    {


        public void ClosingDoor(DoorContext door)
        {
            if (door.leftDoor_1.Left < door.liftBase.Left)
            {
                // Move both doors toward the center
                door.leftDoor_1.Left += door.DoorSpeed;
                door.rightDoor_1.Left -= door.DoorSpeed;
            }
            else
            {
                // Stop the closing timer when fully closed
                door.close1.Stop();
                door.firstFloor.Enabled = true;
                door.groundFloor.Enabled = true;
                door.GoDown.Enabled = true;
                door.GoUp.Enabled = true;

                door._CurrentState = new IDoorIdle();
            }
        }

        public void OpeningDoor(DoorContext door)
        {
        }
    }
}
