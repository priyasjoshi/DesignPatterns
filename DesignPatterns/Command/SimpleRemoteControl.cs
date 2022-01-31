using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    //Invoker: holds a command and at some point asks the command to carry out a request
    //by calling its execute() method.
    class SimpleRemoteControl
    {
        Command slot;
        public SimpleRemoteControl() {
        }
        public void setCommand(Command command) {
            slot = command;
        }
        public void buttonWasPressed() {
            slot.execute();
        }
    }
}
