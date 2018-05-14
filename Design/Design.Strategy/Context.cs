using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Strategy
{
    public class Context
    {
        private Operation operation;
        public Context(string OperationStr)
        {
            OperationFactory operationFactory = new OperationFactory();
            operation = operationFactory.CreateFactory(OperationStr);
        }
        public Double Execute(double NumA, double NumB)
        {
            return operation.GetResult(NumA, NumB);
        }
    }
}
