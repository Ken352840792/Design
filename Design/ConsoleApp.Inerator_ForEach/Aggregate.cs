using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Inerator_ForEach
{
    abstract class Aggregate
    {
        public abstract void Add(object o);
        public abstract void RemoveIndex(int index);
    }
}
