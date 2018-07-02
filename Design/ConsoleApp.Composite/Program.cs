using System;

namespace ConsoleApp.Composite
{
    /// <summary>
    /// 组合模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Composite composite = new Composite("root");
            composite.Add(new Leaf(" Leaf A"));
            composite.Add(new Leaf(" Leaf B"));

            Composite composite_A = new Composite("Composite A");
            composite_A.Add(new Leaf(" Composite A Leaf A"));
            composite_A.Add(new Leaf(" Composite A Leaf B"));
            Composite composite_B = new Composite("Composite B");
            composite_B.Add(new Leaf(" Composite B Leaf A"));
            composite_B.Add(new Leaf(" Composite B Leaf B"));
            composite_A.Add(composite_B);
            composite.Add(composite_A);

            composite.Display(1);
             
            Console.ReadLine();
        }
    }
}
