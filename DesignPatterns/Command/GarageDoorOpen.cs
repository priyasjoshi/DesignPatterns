using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    //Concrete Command responsible for settings it's receiver
    class GarageDoorOpen : Command
    {
        GarageDoor gd;
        public GarageDoorOpen(GarageDoor g) {
            gd = g;
        }
        public void execute()
        {
            gd.up();
        }

        public void undo()
        {
            gd.down();
        }
    }
}
