using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string message,Colleague colleague);
    }
}
