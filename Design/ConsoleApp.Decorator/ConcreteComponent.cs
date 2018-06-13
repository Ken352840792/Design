using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Decorator
{
    class ConcreteComponent : Component
    {
        
        public override double Operation(double Prices)
        {
            Console.WriteLine("我准备秀出我自己了");
           return  decorator.Operation(Prices);
        }
        private Decorator decorator;
        public void SetDecorator(Decorator decorator) {
           
            this.decorator = decorator;
        }
    }
}
