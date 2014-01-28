using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{



    abstract class MazeObject
    {
        //protected Surroundings _surroundings;
        private bool _discovered;


        protected MazeObject()
        {
            //_surroundings = new Surroundings();
            _discovered = false;
        }


        // player interaction with the maze is movement? (if it is an air block)
        abstract public void die();
        abstract public override string ToString();
        abstract public bool interact();
        //abstract public bool interact(Direction d);

        public void setDiscovered(bool b)
        {
            _discovered = b;
        }

        public bool getDiscovered()
        {
            return _discovered;
        }

        //public Surroundings getSurroundings()
        //{
        //    return _surroundings;
        //}
        
    }
}
