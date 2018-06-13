using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.StateObserver
{
    public abstract class State
    {
        public abstract void Write(Work work);
    }
}
