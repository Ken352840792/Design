using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Command
{
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.ActionA();
        }
    }
}
