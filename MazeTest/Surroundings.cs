using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class Surroundings
    {
        private MazeNodeObject _left;
        private MazeNodeObject _right;
        private MazeNodeObject _up;
        private MazeNodeObject _down;


        public Surroundings()
        {
            _left = null;
            _right = null;
            _up = null;
            _down = null;
        }


        //setters-------------------------------

        public void setLeft(MazeNodeObject left)
        {
            _left = left;
        }

        public void setRight(MazeNodeObject right)
        {
            _right = right;
        }

        public void setUp(MazeNodeObject up)
        {
            _up = up;
        }

        public void setDown(MazeNodeObject down)
        {
            _down = down;
        }

        //getters-------------------------------

        public MazeNodeObject getLeft()
        {
            return _left;
        }

        public MazeNodeObject getRight()
        {
            return _right;
        }

        public MazeNodeObject getUp()
        {
            return _up;
        }

        public MazeNodeObject getDown()
        {
            return _down;
        }



    }
}
