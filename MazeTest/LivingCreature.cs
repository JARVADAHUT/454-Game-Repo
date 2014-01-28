using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    abstract class LivingCreature : MazeObject
    {
        protected int hitPoints;
        protected int resourcePoints;
        protected string name;

        abstract public bool interact(EnumDirection d);
    }
}
