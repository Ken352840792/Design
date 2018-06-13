using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Observer
{
    class A_Observer
    {
        private string Name;
        public A_Observer(string name)
        {
            this.Name = name;
        }
        public void CloseTV(object o, EventArgs eventArgs)
        {
            Console.WriteLine("{0}  自己的名称:{1} 关闭TV ,附带属性:{2}", ((Subject)o).SubjectState, Name,((test)eventArgs).Name);
        }
    }
}
