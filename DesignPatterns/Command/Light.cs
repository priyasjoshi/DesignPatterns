using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    //Receiver
    class Light
    {
        public void On()
        {
            Console.WriteLine("Light is On");
        }
        public void Off()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
