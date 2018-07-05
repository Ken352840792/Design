using System;
namespace ConsoleApp.Mediator
{
     class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(Mediator mediator) : base(mediator)
        {
        }
        public void Send(string message) {
            mediator.Send(message,this);
        }
        public void Notify(string message) {
            Console.WriteLine("同事B得到消息："+message);
        }
    }
}