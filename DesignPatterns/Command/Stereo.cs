using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    class Stereo
    {
        public void On() {
            Console.WriteLine("Stereo is on");
        }
        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }
        public void setCD()
        {
            Console.WriteLine("CD is set");
        }
        public void setDVD()
        {
            Console.WriteLine("Dvd is set");
        }
        public void setRadio()
        {
            Console.WriteLine("Radio is set");
        }
        public void setVolume(int volume)
        {
            Console.WriteLine("Volume is set to " + volume);
        }
    }
}
