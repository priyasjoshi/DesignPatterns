using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    class LightOffCommand : Command
    {
        Light lightoff;
        public LightOffCommand(Light l) {
            lightoff = l;
        }
        public void execute()
        {
            lightoff.Off();
        }

        public void undo()
        {
            lightoff.On();
        }
    }
}
