using System;

namespace ConsoleApp.Bridge
{
    /// <summary>
    /// 桥接模式（有点不是很明白，现在脑子有点浆糊）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.SetImplementor(new ConcreteImplementorA());
            abstraction.Operation();

            abstraction.SetImplementor(new ConcreteImplementorB());
            abstraction.Operation();
            Console.Read();
        }
    }
}
