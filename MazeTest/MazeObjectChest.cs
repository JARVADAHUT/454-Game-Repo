using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectChest : MazeObject
    {
        public MazeObjectChest() : base()
        {

        }

        public override void die()
        {

        }

        public override string ToString()
        {
            return "c";
        }
        public override bool interact()
        {
            return false;
        }
    }
}
