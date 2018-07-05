using System;

namespace ConsoleApp.Mediator
{
    /// <summary>
    /// 中介者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //构造一个中介
            ConcreteMediator concreteMediator = new ConcreteMediator();
            //构造同事A 
            ConcreteColleagueA concreteColleagueA = new ConcreteColleagueA(concreteMediator);
            //构造同事B
            ConcreteColleagueB concreteColleagueB = new ConcreteColleagueB(concreteMediator);
            concreteMediator.concreteColleagueA = concreteColleagueA;
            concreteMediator.concreteColleagueB = concreteColleagueB;
            concreteColleagueA.Send("你好啊 ");
            concreteColleagueB.Send("我不好，我牙疼~");
            Console.Read();
        }
    }

}
