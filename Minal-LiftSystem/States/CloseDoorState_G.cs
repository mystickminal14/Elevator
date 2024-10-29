using Minal_LiftSystem.Context;
using Minal_LiftSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minal_LiftSystem.States
{
    internal class CloseDoorState_G : IDoor

    {
       

        public void ClosingDoor(DoorContext door)
        {

            if (door.leftDoor_G.Left < door.liftBase.Left)
            {
                // Move both doors toward the center
                door.leftDoor_G.Left += door.DoorSpeed;
                door.rightDoor_G.Left -= door.DoorSpeed;
            }
            else
            {
                // Stop the closing timer when fully closed
                door.closeG.Stop();
                door._CurrentState = new IDoorIdle();
                door.firstFloor.Enabled = true;
                door.groundFloor.Enabled = true;
                door.GoDown.Enabled = true;
                door.GoUp.Enabled = true;

            }
        }

        public void OpeningDoor(DoorContext door)
        {
        }
    }
}
