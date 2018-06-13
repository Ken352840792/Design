using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.StateObserver
{
    class ForenoonState : State
    {
        public override void Write(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine("上午 的工作进行中 现在的时间是:" + work.Hour);
            }
            else {
                //转到中午状态
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}
