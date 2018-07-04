using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Command
{
    abstract class Command
    {
        protected Receiver receiver;

        protected Command(Receiver receiver)
        {
            this.receiver = receiver;
        }
        abstract public void Execute();

    }
}
