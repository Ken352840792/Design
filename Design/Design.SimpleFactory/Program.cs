using System;

namespace Design.SimpleFactory
{
    /// <summary>
    /// 简单工厂模式
    /// 定义：简单工厂模式是由一个工厂对象决定创建出哪一种产品类的实例
    /// 好处：
    /// 1.对外封装了具体的对象的创建过程
    /// 坏处：
    /// 1.由于工厂聚集了所有的实例创建的过程,违反了"高内聚"职责分配原则;一旦要添加新的类,就需要改变工厂对象!
    /// 例子：
    /// 如果现在需要去打造一把锤子流程如下
    /// >* 用简单工厂模式
    /// A.找到一个工厂
    /// B.自己告诉工厂自己想打造的款式
    /// C.工厂开始打造
    /// D.拿到自己的锤子
    /// >* 不用简单工厂模式
    /// A.自己理解自己想要打造的款式
    /// B.自己开始打造
    /// C.经过不断的尝试,终于可以拿到自己想要的结果
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //创建工厂对象 A
            OperationFactory operationFactory = new OperationFactory();
            //创建操作实例的对象 B
            Operation operation = operationFactory.CreateFactory("Add");
            //调用实例拿到结果 C D
            operation.GetResult(1, 1);
        }
    }
}
