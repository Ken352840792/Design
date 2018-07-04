using System;

namespace ConsoleApp.Chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handlerA = new ConcreteHandleA();
            Handler handlerB = new ConcreteHandleB();
            Handler handlerC = new ConcreteHandleC();
            handlerA.SetHandler(handlerB);
            handlerB.SetHandler(handlerC);
            int[] requests = { 1,2,5,6,89,21,3,324,33,22,43,6,2,32};
            foreach (var item in requests)
            {
                handlerA.HandleRequest(item);
            }
            Console.Read();
        }
    }
}
