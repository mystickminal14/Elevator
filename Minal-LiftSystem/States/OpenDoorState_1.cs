using Minal_LiftSystem.Context;
using Minal_LiftSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minal_LiftSystem.States
{
    internal class OpenDoorState_1 : IDoor

    {


        public void ClosingDoor(DoorContext door)
        {

        }

        public void OpeningDoor(DoorContext door)
        {
            if (door.leftDoor_1.Left > door.liftBase.Left - door.DoorMaxOpenWidth)
            {
                // Move both doors away from the center
                door.leftDoor_1.Left -= door.DoorSpeed;
                door.rightDoor_1.Left += door.DoorSpeed;
            }
            else
            {
                // Stop the opening timer when fully open
                door.open1.Stop();
                door._CurrentState = new IDoorIdle();
                door.firstFloor.Enabled = false;
                door.groundFloor.Enabled = false;
                door.GoDown.Enabled = false;
                door.GoUp.Enabled = false;

            }
        }
    }
}
