using System;
using System.Collections.Generic;
using System.Text;

namespace Design.SimpleFactory
{
    public class Operation
    {
        public virtual double GetResult(double NumA, double NumB)
        {
            return 0;
        }
    }
}
