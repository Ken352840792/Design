using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Chain_of_responsibility
{
    abstract class Handler
    {
        protected Handler handler;
        public void SetHandler(Handler handler)
        {
            this.handler = handler;
        }
        public abstract void HandleRequest(int request);
    }
}
