using System;

namespace ConsoleApp.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();
            var MyConcreteDecoratorBase = new ConcreteDecoratorC();//满300减100
            MyConcreteDecoratorBase
                .SetComponent(new ConcreteDecoratorC())//满300减100
                .SetComponent(new ConcreteDecoratorA())//打七折
                .SetComponent(new ConcreteDecoratorB())//打5折
                .SetComponent(new ConcreteDecoratorB());//打5折
            concreteComponent.SetDecorator(MyConcreteDecoratorBase);
            Console.WriteLine("最后的结果值为:" + concreteComponent.Operation(4000));
            Console.ReadLine();
        }
    }
}
