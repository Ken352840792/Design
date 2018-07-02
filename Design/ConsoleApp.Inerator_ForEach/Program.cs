using System;
using System.Collections.Generic;

namespace ConsoleApp.Inerator_ForEach
{
    /// <summary>
    /// 迭代器模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //上车
            ConcreateAggregate concreateAggregate = new ConcreateAggregate();
            concreateAggregate.Add("张三");
            concreateAggregate.Add("张三1");
            concreateAggregate.Add("张三2");
            concreateAggregate.Add("张三3");
            //迭代器
            Iterator i =new ConcreateIteratorDesc(concreateAggregate);
            while (!i.IsDone())
            {
                Console.WriteLine(i.CurrentItem());
                i.Next();
            }
            Console.ReadLine();
        }
    }
}
