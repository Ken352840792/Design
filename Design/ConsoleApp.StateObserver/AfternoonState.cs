using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.StateObserver
{
    class AfternoonState : State
    {
        public override void Write(Work work)
        {
            if (work.Hour <= 17)
            {
                Console.WriteLine("下午 的工作进行中 现在的时间是:" + work.Hour);
            }
            else {
                //转到下班判断状态
                work.SetState(new TaskFinished());
                work.WriteProgram();
            }
        }
    }
}
