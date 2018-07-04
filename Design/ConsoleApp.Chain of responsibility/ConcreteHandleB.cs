using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Chain_of_responsibility
{
    class ConcreteHandleB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} 请假小时：{1}", "经理审批", request);
            }
            else if (handler != null)
            {
                handler.HandleRequest(request);
            }
        }
    }
}
