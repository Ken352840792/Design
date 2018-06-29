using System;

namespace ConsoleApp.Memento
{
    class Program
    {
        //备忘录模式:保存对象的状态至一个地方 然后在需要回复对象状态的时候即可直接还原
        //与打游戏时候，在撸boss之前，记得保存一下，备忘录模式就是做的这个事情
        //代码运行逻辑：先初始化一个人，然后设置这个人的属性/状态以后，让这个人自己创建一个副本到一个管理中心中去，如果想还原的时候，只需要到管理中心去取就好了
        static void Main(string[] args)
        {
            //初始化人的对象
            Originator originator = new Originator();
            originator.State = "我是之前的状态";
            originator.Show();

            //管理者对象
            Caretaker caretaker = new Caretaker();
            //创建一个副本保存在管理者对象中
            caretaker.Memento = originator.CreateMenmento();
            //设置发起者对象状态
            originator.State = "我是现在的状态";
            originator.Show();
            //还原状态状态
            originator.SetMemento(caretaker.Memento);
            originator.Show();
        }
    }
}
