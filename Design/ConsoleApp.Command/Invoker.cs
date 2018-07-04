using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Command
{
    class Invoker
    {
        private Command command;
        List<Command> commands = new List<Command>();
        public void SetCommand(Command command)
        {
            commands.Add(command);
        }
        public void ExecuteCommand()
        {
            foreach (var item in commands)
            {
                item.Execute();
            }
        }
    }
}
