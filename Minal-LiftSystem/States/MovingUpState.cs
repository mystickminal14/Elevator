using Minal_LiftSystem.Context;
using Minal_LiftSystem.Interfaces;
using System.Drawing;

namespace Minal_LiftSystem.States
{
     internal class MovingUpState : ILift
    {
        public void MovingDown(Lift lift)
        {
            // Do Nothing
        }

        public void MovingUp(Lift lift)
        {
            int distanceToFirstFloor = lift.LiftBase.Top - lift.FirstFloorY;

            if (distanceToFirstFloor >= lift.LiftSpeed)

                {
                // Move the lift up by liftSpeed
                lift.LiftBase.Top -= lift.LiftSpeed;
                lift.open.Enabled = false;
                lift.close.Enabled = false;// Adjust LiftBase.Top, not FirstFloorY
            }
            else
            {
                // Snap to the exact first floor position
                lift.LiftBase.Top = lift.FirstFloorY;

                // Transition to Idle state and stop movement
                lift.SetState(new Idle());
                lift.CurrentFloor = 1;
                lift.FirstFloor.BackColor = Color.White;
                lift.LiftTimerUp.Stop();

                // Update displays and disable/enable buttons accordingly
                lift.Display.Text = $"1";
                lift.Display_1.Text = $"1";
                lift.Display_G.Text = $"1";
                lift.GroundFloor.Enabled = true;
                lift.FirstFloor.Enabled = true;
                lift.GoDown.Enabled = true;
                lift.open.Enabled = true;
                lift.close.Enabled = true;
                lift.open.PerformClick();
                
                lift.GoUp.Enabled = true;
            }
        }
    }
}

