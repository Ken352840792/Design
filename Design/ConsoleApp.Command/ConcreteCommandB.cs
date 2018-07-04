using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Command
{
    class ConcreteCommandB : Command
    {
        public ConcreteCommandB(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.ActionB();
        }
    }
}
