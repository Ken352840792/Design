using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Bridge
{
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体的实现A方法执行");
        }
    }
}
