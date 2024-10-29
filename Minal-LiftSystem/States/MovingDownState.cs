using Minal_LiftSystem.Context;
using Minal_LiftSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minal_LiftSystem.States
{
    
       internal class MovingDownState : ILift
    {
        public void MovingDown(Lift lift)
        {
            int distanceToGround = lift.GroundFloorY - lift.LiftBase.Top;

            if (distanceToGround > lift.LiftSpeed)
            {
                // Move the lift down by liftSpeed
                lift.LiftBase.Top += lift.LiftSpeed;
                lift.open.Enabled = false;
                lift.close.Enabled = false;// Adjust LiftBase.Top, not GroundFloorY
            }
            else
            {
                // Snap to the exact ground floor position
                lift.LiftBase.Top = lift.GroundFloorY;

                // Transition to Idle state and stop movement
                lift.SetState(new Idle());
                lift.GroundFloor.BackColor = Color.White;
                lift.LiftTimerDown.Stop();
                
                lift.CurrentFloor = 0;
                // Update displays and disable/enable buttons accordingly
                lift.Display.Text = $"G";
                lift.Display_1.Text = $"G";
                lift.Display_G.Text = $"G";
                lift.FirstFloor.Enabled = true;
                lift.GroundFloor.Enabled = true;
                lift.GoDown.Enabled = true;
                lift.open.Enabled = true;
                lift.close.Enabled = true;
                lift.GoUp.Enabled = true;
                lift.open.PerformClick();

            }
        }

        public void MovingUp(Lift lift)
        {
            // Do Nothing
        }
    }
}

