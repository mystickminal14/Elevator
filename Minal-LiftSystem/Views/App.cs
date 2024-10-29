using Minal_LiftSystem.Context;
using Minal_LiftSystem.db;
using Minal_LiftSystem.States;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minal_LiftSystem
{
    public partial class App : Form
    {
        int doorSpeed = 5;
        int liftSpeed = 10;
        private int groundFloorY;
        private int firstFloorY;
        private Lift lift;
        float doorMaxOpenWidth;
        private Timer doorOpenTimer;
        private Timer doorCloseTimer;
        private DoorContext doorContext;
        DataTable dt = new DataTable();
        Conn db= new Conn();
        public App()
        {
            InitializeComponent();
            groundFloorY = LiftLeftDoor_G.Location.Y;
            firstFloorY = LiftLeftDoor_1.Location.Y;
            doorMaxOpenWidth = (float)(LiftBase.Width / 1.8);
            recordView.ColumnCount = 2;
            recordView.Columns[0].Name = "Time";
            recordView.Columns[1].Name = "Events";

            dt.Columns.Add("LogTime");
            dt.Columns.Add("EventDescription");

            lift = new Lift(LiftBase, firstFloor, groundFloor, this.ClientSize.Height, liftSpeed, LiftTimerUp, LiftTimerDown, groundFloorY, firstFloorY, GoUp,GoDown,display,display_1,display_g,OpenDoor,CloseDoor);
            doorContext = new DoorContext(LiftBase,LiftLeftDoor_1,LiftRightDoor_1, LiftRightDoor_G, LiftLeftDoor_G,OpenDoor, CloseDoor, doorSpeed, doorMaxOpenWidth,OpenDownTimer,CloseDownTimer,OpenUpTimer,CloseUpTimer,firstFloor,groundFloor,GoUp,GoDown);
            
           
        }
        private void log(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            dt.Rows.Add(currentTime, message);
            recordView.Rows.Add(currentTime, message);

            db.InsertLogsIntoDB(dt);
        }

        private void firstFloor_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingUpState());
            LiftTimerUp.Start();
            firstFloor.Enabled = false;
            groundFloor.Enabled = false;
            GoDown.Enabled = false;
            OpenDoor.Enabled = false;
            CloseDoor.Enabled = false;
            GoUp.Enabled = false;
            log("Lift is arriving at first floor!");
        }

        private void groundFloor_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingDownState());
            LiftTimerDown.Start();
            firstFloor.Enabled = false;
            groundFloor.Enabled = false;
            GoDown.Enabled = false;
            GoUp.Enabled = false;
            OpenDoor.Enabled = false;
            CloseDoor.Enabled = false;
            log("Lift is arriving at ground floor!");

        }



        private void LiftTimerUp_Tick(object sender, EventArgs e)
        {
            lift.MovingUp();
        }

        private void LiftTimerDown_Tick(object sender, EventArgs e)
        {
            lift.MovingDown();

        }

        private void GoDown_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingUpState());
            LiftTimerUp.Start();
            firstFloor.Enabled = false;
            groundFloor.Enabled = false;
            GoDown.Enabled = false;
            GoUp.Enabled = false;
            log("Lift is arriving at ground floor!");

        }

        private void GoUp_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingDownState());
            LiftTimerDown.Start();
            firstFloor.Enabled = false;
            groundFloor.Enabled = false;
            GoDown.Enabled = false;
            GoUp.Enabled = false;
            log("Lift is arriving at first floor!");


        }

        private void CloseDownTimer_Tick(object sender, EventArgs e)
        {
            doorContext.ClosingDoor();
        }

        private void OpenDownTimer_Tick(object sender, EventArgs e)
        {
            doorContext.OpeningDoor();
        }

        private void CloseUpTimer_Tick(object sender, EventArgs e)
        {
            doorContext.ClosingDoor();
        }

        private void OpenUpTimer_Tick(object sender, EventArgs e)
        {
            doorContext.OpeningDoor();
        }

        private void OpenDoor_Click(object sender, EventArgs e)
        {
            

            if (lift.CurrentFloor == 1)
            {
                doorContext.SetState(new OpenDoorState_1());
                OpenUpTimer.Start();
                firstFloor.Enabled = false;
                groundFloor.Enabled = false;
                GoDown.Enabled = false;
                GoUp.Enabled = false;
                log("Door of first floor is being opened!");

            }
            else
            {
                doorContext.SetState(new OpenDoorState_G());
                OpenDownTimer.Start();
                firstFloor.Enabled = false;
                groundFloor.Enabled = false;
                GoDown.Enabled = false;
                GoUp.Enabled = false;
                log("Door of ground floor is being opened!");

            }
        }

        private void CloseDoor_Click(object sender, EventArgs e)
        {
            

            if (lift.CurrentFloor == 1)
            {
                doorContext.SetState(new CloseDoorState_1());
                CloseUpTimer.Start();
                firstFloor.Enabled = false;
                groundFloor.Enabled = false;
                GoDown.Enabled = false;
                GoUp.Enabled = false;
                log("Door of first floor is being closed!");

            }
            else
            {
                doorContext.SetState(new CloseDoorState_G());
                CloseDownTimer.Start();
                firstFloor.Enabled = false;
                groundFloor.Enabled = false;
                GoDown.Enabled = false;
                GoUp.Enabled = false;
                log("Door of ground floor is being closed!");

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {

            db.loadLogsFromDB(dt, recordView);
        }
    }
}
