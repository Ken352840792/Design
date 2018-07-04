using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Bridge
{
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.Write("具体的实现B方法执行");
        }
    }
}
