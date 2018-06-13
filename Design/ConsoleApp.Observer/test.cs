using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Observer
{
    class test:EventArgs
    {
        public string Name { get; set; }
        public void aaa() {
            Console.WriteLine("test");
        }
    }
}
