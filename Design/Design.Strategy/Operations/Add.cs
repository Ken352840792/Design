﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Strategy.Operations
{
    public class Add : Operation
    {
        public override double GetResult(double NumA, double NumB)
        {
            return NumA + NumB;
        }
    }
}
