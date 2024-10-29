using Minal_LiftSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minal_LiftSystem.Interfaces
{
    internal class Idle : ILift
    {
        public void MovingDown(Lift lift)
        {
            /* Do Nothing */
        }

        public void MovingUp(Lift lift)
        {
            /* Do Nothing */
        }
    }
    
    
}
