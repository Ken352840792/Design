using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Decorator
{
    abstract class Decorator : Component
    {
        protected Component component;
        public Decorator SetComponent(Decorator component)
        {
            this.component = component;
            return component;
        }
        public override double Operation(double Prices)
        {
            if (component != null)
            {
              return  component.Operation(Prices);
            }
            return Prices;
        }
    }
}
