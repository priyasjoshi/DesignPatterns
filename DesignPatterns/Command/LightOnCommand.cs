using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    class LightOnCommand : Command
    {
        Light light;
        public LightOnCommand(Light l) {
            light = l;
        }
        public void execute()
        {
            light.On();
        }

        public void undo()
        {
            light.Off();
        }
    }
}
