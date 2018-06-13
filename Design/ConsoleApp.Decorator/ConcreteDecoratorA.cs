using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Decorator
{
    class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override double Operation(double Prices)
        {
            Prices = Prices * 0.7;
            addedState = "New State";
            Console.WriteLine("打7折后值为:" + Prices);
            return base.Operation(Prices);
        }
    }
}
