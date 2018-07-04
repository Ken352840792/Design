using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Bridge
{
    class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            base.implementor.Operation();
        }
    }
}
