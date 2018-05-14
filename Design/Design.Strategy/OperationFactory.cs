
using Design.Strategy.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Strategy
{
    public class OperationFactory
    {
        public Operation CreateFactory(string OperationStr)
        {
            switch (OperationStr)
            {
                case "Add":
                    return new Add();
                case "Sub":
                    return new Sub();
                case "Mul":
                    return new Mul();
                case "Div":
                    return new Div();
                default:
                    return new Add();
            }

        }
    }
}
