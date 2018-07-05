using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interpreter
{
    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
