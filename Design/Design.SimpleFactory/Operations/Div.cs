using System;
using System.Collections.Generic;
using System.Text;

namespace Design.SimpleFactory.Operations
{
   public class Div:Operation
    {
        public override double GetResult(double NumA, double NumB)
        {
            if (NumB == 0)
                return 0;
            return NumA/NumB;
        }
    }
}
