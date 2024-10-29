using Minal_LiftSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minal_LiftSystem.Context
{
    internal class Lift
    {
        public Button open;
        public Button close;
        public DoorContext doorContext;
        public ILift  _CurrentState;
        public int CurrentFloor=0;
    public PictureBox LiftBase;
    public Button FirstFloor;
    public Button GroundFloor;
    public Button GoDown;
    public Button GoUp;
        public int FormSize;
    public int LiftSpeed;
    public Timer LiftTimerUp;
    public Timer LiftTimerDown;
        public int GroundFloorY;
        public int FirstFloorY;
        public Button Display;
        public Button Display_1;
        public Button Display_G;


        public Lift(PictureBox liftBase, Button firstFloor, Button groundFloor, int formSize, int liftSpeed, Timer liftTimerUp, Timer liftTimerDown ,int groundFloorY,int firstFloorY ,Button goUp,Button goDown, Button display, Button display_1, Button display_g,Button opend,Button closed)
    {
        LiftBase = liftBase;
        FirstFloor = firstFloor;
        GroundFloor = groundFloor;
         FormSize = formSize;
        LiftSpeed = liftSpeed;
        LiftTimerUp = liftTimerUp;
        LiftTimerDown =liftTimerDown;
            GroundFloorY = groundFloorY;
            FirstFloorY = firstFloorY;
           GoUp= goUp;
            GoDown = goDown;
            Display = display;
            Display_1 = display_1;
            Display_G = display_g;
            open = opend;
            close = closed;
        _CurrentState = new Idle();
    }

    public void SetState(ILift state)
    {
        _CurrentState = state;
    }

    public void MovingUp()
    {
        _CurrentState.MovingUp(this);
    }

    public void MovingDown()
    {
        _CurrentState.MovingDown(this);
    }


}
}
