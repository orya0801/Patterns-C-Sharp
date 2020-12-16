using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9_Command
{
    class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;

        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

        public void Undo()
        {
            commands[current - 1].UnExecute();
        }
        public void Redo()
        {
            commands[current - 1].Execute();
        }

        public void Undo(int i)
        {
            commands[current - i].UnExecute();
        }

        public void Redo(int i)
        {
            commands[current - i].Execute();
        }
    }
}
