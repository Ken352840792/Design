using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Mediator
{
    class ConcreteMediator : Mediator
    {

        public ConcreteColleagueA concreteColleagueA { get; set; }
        public ConcreteColleagueB concreteColleagueB { get; set; }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == concreteColleagueA)
            {
                concreteColleagueB.Notify(message);
            }
            else {
                concreteColleagueA.Notify(message);
            }
        }
    }
}
