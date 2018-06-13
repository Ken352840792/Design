using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Observer
{
    class B_Observer
    {
        private string Name;
        public B_Observer(string name)
        {
            this.Name = name;
        }
        public void CloseZhibo(object o, EventArgs eventArgs)
        {
            Console.WriteLine("{0}    自己的名称:{1} 关闭直播", ((Subject)o).SubjectState, Name);
        }
    }
}
