using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.StateObserver
{
    class TaskFinished : State
    {
        public override void Write(Work work)
        {
            if (work.TaskFinished)
            {
                Console.WriteLine("我的事情做完了 下班咯 别打扰我 现在的时间是:" + work.Hour);
            }
            else {
                //任务没有做完，继续做！！！
                Console.WriteLine("我的事情还没有做完 继续加班吧~ 现在的时间是："+work.Hour);
            }
        }
    }
}
