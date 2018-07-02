using System;

namespace ConsoleApp.Observer
{
    /// <summary>
    /// 观察者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Boss boos = new Boss();
            A_Observer a_Observer = new A_Observer("张三");
            A_Observer a_Observer_1 = new A_Observer("李四");
            B_Observer b_Observer = new B_Observer("王五");
            //订阅过程
            boos.Update += new EventHandler(a_Observer.CloseTV);
            boos.Update += new EventHandler(a_Observer_1.CloseTV);
            boos.Update += new EventHandler(a_Observer_1.CloseTV);
            boos.Update += new EventHandler(b_Observer.CloseZhibo);
            //通知大家，赶快撤
            boos.SubjectState = "公司老大回来了";
            boos.Notify();
            Console.ReadLine();
        }
    }
}
