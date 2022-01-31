using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    class NoCommand : Command
    {
        public void execute()
        {
            Console.WriteLine("No command...");
        }

        public void undo()
        {
            Console.WriteLine("No command...");
        }
    }
}
