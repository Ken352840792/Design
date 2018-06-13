using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Decorator
{
    class ConcreteDecoratorC:Decorator
    {
        public override double Operation(double Prices)
        {

            Prices=Prices-((int)(Prices / 300)) * 100;
            Console.WriteLine("满300减50后值为:"+Prices);
           return base.Operation(Prices);
        }
    }
}
