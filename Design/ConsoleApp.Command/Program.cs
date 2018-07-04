using System;

namespace ConsoleApp.Command
{
    /// <summary>
    /// 命令模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //初始化门店
            Receiver receiver = new Receiver();
            //初始化菜单
            Command commandA = new ConcreteCommand(receiver);
            Command commandB = new ConcreteCommandB(receiver);
            //初始化服务员
            Invoker invoker = new Invoker();
            //下单点菜
            invoker.SetCommand(commandA);
            invoker.SetCommand(commandB);
            //去做菜吧
            invoker.ExecuteCommand();
            Console.Read();
        }
    }
}
