using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Inerator_ForEach
{
    class ConcreateIteratorDesc : Iterator
    {
        ConcreateAggregate aggregate;
        int current = 0;
        public ConcreateIteratorDesc(ConcreateAggregate concreateAggregate)
        {
            this.aggregate = concreateAggregate;
            current = aggregate.Count - 1;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object Frist()
        {
            return aggregate[aggregate.Count - 1];
        }

        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }

        public override object Next()
        {
            current--;
            return current >= 0 ? aggregate[current] : null;
        }
    }
}
