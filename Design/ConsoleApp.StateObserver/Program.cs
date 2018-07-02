using System;

namespace ConsoleApp.StateObserver
{
    /// <summary>
    /// 状态模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            for (int i = 9; i < 24; i++)
            {
                work.Hour = i;
                if (i==21) {
                    work.TaskFinished = true;
                }
                work.WriteProgram();
            }
            Console.ReadLine();
        }
    }
}
