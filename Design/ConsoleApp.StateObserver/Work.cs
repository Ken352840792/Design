using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.StateObserver
{
    public class Work
    {
        private State current;
        public Work()
        {
            //初始化为上午
            current = new ForenoonState();
        }
        public double Hour { get; set; }
        public bool TaskFinished { get; set; }
        public void SetState(State s) {
            current = s;
        }
        public void WriteProgram() {
            current.Write(this);
        }
    }
}
