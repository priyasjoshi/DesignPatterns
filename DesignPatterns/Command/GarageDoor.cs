using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    //Receiver
    class GarageDoor
    {
        public void up() {
            Console.WriteLine("Garage Door is up.");
        }
        public void down()
        {
            Console.WriteLine("Garage Door is down.");
        }
        public void stop()
        {
            Console.WriteLine();
        }
        public void lightOn()
        {
            Console.WriteLine();
        }
        public void lightOff()
        {
            Console.WriteLine();
        }
    }
}
