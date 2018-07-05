using System;
using System.Collections.Generic;

namespace ConsoleApp.Interpreter
{
    /// <summary>
    /// 解释器模式-初步理解了~ 还需要深入
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            IList<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            foreach (var item in list)
            {
                item.Interpret(context);
            }
            Console.Read();
        }
    }
}
