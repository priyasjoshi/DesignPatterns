using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    class StereoOnWithCDCommand : Command
    {
        Stereo stereo;
        public StereoOnWithCDCommand(Stereo s) {
            stereo = s;
        }
        public void execute()
        {
            stereo.On();
            stereo.setCD();
            stereo.setVolume(11);
        }

        public void undo()
        {
            stereo.Off();
        }
    }
}
