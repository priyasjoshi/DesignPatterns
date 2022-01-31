using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    class GarageDoorDown : Command
    {
        GarageDoor gd;
        public GarageDoorDown(GarageDoor g) {
            gd = g;
        }
        public void execute()
        {
            gd.down();
        }

        public void undo()
        {
            gd.up();
        }
    }
}
