using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Observer
{
    class SecretaryA : Subject
    {
        private string action;
        public string SubjectState { get => action; set => this.action = value; }
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
