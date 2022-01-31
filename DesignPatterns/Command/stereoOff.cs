using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    class stereoOff : Command
    {
        Stereo s;
        public stereoOff(Stereo ss) {
            s = ss;
        }
        public void execute()
        {
            s.Off();
        }

        public void undo()
        {
            s.On();
        }
    }
}
