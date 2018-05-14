using System;
using System.Collections.Generic;
using System.Text;

namespace Design.SimpleFactory.Operations
{
    public class Sub : Operation
    {
        public override double GetResult(double NumA, double NumB)
        {
            return NumA - NumB;
        }
    }
}
