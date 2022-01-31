using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    class MacroCommands : Command
    {
        Command [] commands;
        Command[] undoCommands;
        public MacroCommands(Command [] commands) {
            this.commands = commands;
        }
        public void execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].execute();
                undoCommands = commands;
            }
        }

        public void undo()
        {
            for (int i = 0; i < undoCommands.Length; i++)
            {
                undoCommands[i].undo();
            }
        }
    }
}
