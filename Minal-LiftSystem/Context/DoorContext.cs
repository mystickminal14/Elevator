using Minal_LiftSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minal_LiftSystem.Context
{
    internal class DoorContext
    {
      
        public Button firstFloor;
        public Button groundFloor;
        public Button GoDown;
        public Button GoUp;
        public Lift lift;
        public IDoor _CurrentState;
        public PictureBox liftBase;
        public PictureBox leftDoor_1;
        public PictureBox rightDoor_1;
        public PictureBox rightDoor_G;
        public PictureBox leftDoor_G;
        public Button openBtn;
        public Button closeBtn;
        public Timer openG;
        public Timer closeG;
        public Timer open1;
        public Timer close1;
        public int DoorSpeed;
        public double DoorMaxOpenWidth;
        public DoorContext(PictureBox LiftBase,PictureBox LeftDoor_1,PictureBox RightDoor_1,PictureBox RightDoor_G,PictureBox LeftDoor_G,Button OpenBtn,Button CloseBtn,int doorspeed, double doorwidth, Timer openDoorG, Timer closeDoorG,Timer openDoor1,Timer closeDoor1,Button first,Button ground,Button up, Button down) {
            liftBase = LiftBase;
            leftDoor_1 = LeftDoor_1;
            rightDoor_1 = RightDoor_1;  
            rightDoor_G = RightDoor_1;  
            leftDoor_G = LeftDoor_G;
            rightDoor_G = RightDoor_G;
            openBtn = OpenBtn;
            closeBtn = CloseBtn;
            DoorSpeed = doorspeed;
            DoorMaxOpenWidth= doorwidth;
            openG = openDoorG;
            closeG = closeDoorG;
            open1 = openDoor1;
            close1 = closeDoor1;
            firstFloor = first;
            groundFloor = ground;
            GoDown = down;
            GoUp = up;
            _CurrentState = new IDoorIdle();
        }

        public void SetState(IDoor state)
        {
            _CurrentState = state;
        }

        public void OpeningDoor()
        {
            _CurrentState.OpeningDoor(this);
        }

        public void ClosingDoor()
        {
            _CurrentState.ClosingDoor(this);
        }
    }
}
