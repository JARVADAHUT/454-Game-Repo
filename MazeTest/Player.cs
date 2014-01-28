using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    /*abstract*/ class Player : LivingCreature
    {
        private static Player _thisPlayer = null;
        MazeNodeObject _position;
        //singleton

        private Player()
        {
            //_position = start;
        }

        public void setPosition(MazeNodeObject pos)
        {
            _position = pos;
        }

        public static Player getInstance()
        {
            return _thisPlayer ?? (_thisPlayer = new Player());
        }

        public override void die()
        {

        }

        public override string ToString()
        {
            return "p";
        }

        public override bool interact()
        {
            return false;
        }

        public override bool interact(EnumDirection dir)
        {
            bool success = _position.move(dir);
            if (success)
                updatePosition(dir);

            return success;
        }

        private void updatePosition(EnumDirection dir)
        {
            switch (dir)
            {
                case EnumDirection.Right:
                    setPosition(_position.getSurroundings().getRight());
                    break;

                case EnumDirection.Left:
                    setPosition(_position.getSurroundings().getLeft());
                    break;

                case EnumDirection.Up:
                    setPosition(_position.getSurroundings().getUp());
                    break;

                case EnumDirection.Down:
                    setPosition(_position.getSurroundings().getDown());
                    break;
            }
        }


    }
}
