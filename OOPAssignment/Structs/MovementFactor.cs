using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Structs
{
    public struct MovementFactor
    {
        public MovementFactor(int xFactor, int yFactor)
        {
            this.XFactor = xFactor;
            this.YFactor = yFactor;
        }

        public int XFactor;
        public int YFactor;
    }
}
