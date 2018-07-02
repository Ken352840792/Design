using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Composite
{
    class Composite : Component
    {
        private List<Component> components = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach (var item in components)
            {
                item.Display(depth + 2);
            }
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}
