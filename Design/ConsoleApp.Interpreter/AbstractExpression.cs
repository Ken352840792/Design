using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interpreter
{
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context  context);
    }
}
