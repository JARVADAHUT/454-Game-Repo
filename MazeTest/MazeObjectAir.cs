using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectAir : MazeObject
    {
        public MazeObjectAir() : base()
        {

        }

        public override void die()
        {

        }

        public override bool interact()
        {
            return true;
        }

        public override string ToString()
        {
            return "a";
        }
    }
}
