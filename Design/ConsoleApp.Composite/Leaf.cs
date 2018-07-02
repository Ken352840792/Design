using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            Console.Write("Cannot Add to leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void Remove(Component component)
        {
            Console.Write("Cannot Remove to leaf");
        }
    }
}
