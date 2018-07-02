using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Inerator_ForEach
{
    abstract class Iterator
    {
        public abstract object Frist();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();

    }
}
