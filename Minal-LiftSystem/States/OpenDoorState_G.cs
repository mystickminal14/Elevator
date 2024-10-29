using Minal_LiftSystem.Context;
using Minal_LiftSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minal_LiftSystem.States
{
    internal class OpenDoorState_G: IDoor
    {
        public void OpeningDoor(DoorContext door)
        {

            if (door.leftDoor_G.Left > door.liftBase.Left - door.DoorMaxOpenWidth)
            {
                // Move both doors away from the center
                door.leftDoor_G.Left -= door.DoorSpeed;
                door.rightDoor_G.Left += door.DoorSpeed;
            }
            else
            {
                // Stop the opening timer when fully open
                door.openG.Stop();
                door._CurrentState = new IDoorIdle();
                door.firstFloor.Enabled = false;
                door.groundFloor.Enabled = false;
                door.GoDown.Enabled = false;
                door.GoUp.Enabled = false;

            }

        }

        public void ClosingDoor(DoorContext door)
        {
           
        }
    }
}
