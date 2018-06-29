using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Memento
{
    class Originator
    {
        public string State { get; set; }
        public Memento CreateMenmento()
        {
            return (new Memento(State));
        }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        public void Show()
        {
            Console.WriteLine($"State={State}");
        }
    }
}
