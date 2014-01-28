using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectExit : MazeObject
    {
        //private LevelEntrance _nextLevel;


        public MazeObjectExit(/*LevelEntrance nextLevel*/) : base()
        {
            //_nextLevel = nextLevel;
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
            return "e";
        }
    }
}
