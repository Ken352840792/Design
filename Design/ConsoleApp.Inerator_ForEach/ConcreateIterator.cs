using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Inerator_ForEach
{
    class ConcreateIterator : Iterator
    {
        ConcreateAggregate aggregate;
        int current = 0;
        public ConcreateIterator(ConcreateAggregate concreateAggregate)
        {
            this.aggregate = concreateAggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object Frist()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object Next()
        {
            current++;
            return current < aggregate.Count ? aggregate[current] : null;
        }
    }
}
