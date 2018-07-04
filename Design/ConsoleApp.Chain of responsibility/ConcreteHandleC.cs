using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Chain_of_responsibility
{
    class ConcreteHandleC : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} 请假小时：{1}", "CTO审批", request);
            }
            else if (handler != null)
            {
                handler.HandleRequest(request);
            }
            else {
                Console.WriteLine("审批不通过，请假时长太长:{0}",request);
            }
        }
    }
}
