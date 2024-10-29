using Minal_LiftSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minal_LiftSystem.Interfaces
{
    internal interface ILift
    {
        void MovingUp(Lift lift);
        void MovingDown(Lift lift);
     
    }
}
