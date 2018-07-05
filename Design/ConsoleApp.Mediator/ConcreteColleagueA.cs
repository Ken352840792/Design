using System;
namespace ConsoleApp.Mediator
{
     class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(Mediator mediator) : base(mediator)
        {
        }
        public void Send(string message) {
            mediator.Send(message,this);
        }
        public void Notify(string message) {
            Console.WriteLine("同事A得到消息："+message);
        }
    }
}