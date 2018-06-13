using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.StateObserver
{
    class NoonState : State
    {
        public override void Write(Work work)
        {
            if (work.Hour < 14)
            {
                Console.WriteLine("中午 的工作进行中 现在的时间是:" + work.Hour);
            }
            else {
                //转到下午状态
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}
