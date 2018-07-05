using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interpreter
{
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }
}
