using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Decorator
{
    class ConcreteDecoratorB:Decorator
    {
        public override double Operation(double Prices)
        {
            Prices = Prices * 0.5;
            AddedBehavior();
            Console.WriteLine("打5折后值为:" + Prices);
           return  base.Operation(Prices);
        }
        private void AddedBehavior() {
            //本类独有的方法，区别于
        }
    }
}
