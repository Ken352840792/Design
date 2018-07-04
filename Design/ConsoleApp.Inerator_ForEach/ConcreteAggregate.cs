using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Inerator_ForEach
{
    class ConcreteAggregate : Aggregate
    {
        IList<object> items = new List<object>();
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
        public object this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items.Insert(index, value);
            }
        }

        public override void Add(object o)
        {
            items.Add(o);
        }

        public override void RemoveIndex(int index)
        {
            items.RemoveAt(index);
        }
    }
}
