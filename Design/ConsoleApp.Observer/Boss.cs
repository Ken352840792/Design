using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Observer
{
    class Boss : Subject
    {
        //事件委托 
        public event EventHandler Update;
        private string action;
        public string SubjectState { get => action; set => this.action = value; }

        public void Notify()
        {
            Update(this, new test() { Name = "沈柱" });
        }
    }
}
