using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Chain_of_responsibility
{
    class ConcreteHandleA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} 请假小时： {1}", "主管审批", request);
            }
            else if (handler != null)
            {
                handler.HandleRequest(request);
            }
        }
    }
}
