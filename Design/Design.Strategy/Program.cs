using System;

namespace Design.Strategy
{
    /// <summary>
    /// 策略模式
    /// 定义：定义一系列的算法,把它们都封装起来,并且使他们能够相互 替换 ！！！ 
    /// 优点：
    /// A. 算法/规则 可以自由切换
    /// B. 避免使用多重条件判断
    /// C. 扩展性好
    /// 缺点：
    /// A. 策略类会增多
    /// B. 系统所有策略都需要向外暴露
    /// 例子：
    /// 不用策略模式
    /// 调用者如果只有简单工厂模式，则在实际调用的时候，需要获取到工厂对象，处理人对象，获取处理结果
    /// 使用策略模式
    /// 在实际调用过的时候，需要获取一个工厂对象，获取结果处理,比上面少了一个处理人对象，把这个处理人对象封装进Context里面去了
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context("Add");
            Console.WriteLine(context.Execute(1, 1));
            Context context2 = new Context("Sub");
            Console.WriteLine(context2.Execute(5,6));
            Console.ReadLine();
        }
    }
}
