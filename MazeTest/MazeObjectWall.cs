using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectWall : MazeObject
    {
        public MazeObjectWall() : base()
        {

        }

        public override void die()
        {
            throw new NotImplementedException();
        }

        public override bool interact()
        {
            return false;
        }

        public override string ToString()
        {
            return "w";
        }
    }
}
