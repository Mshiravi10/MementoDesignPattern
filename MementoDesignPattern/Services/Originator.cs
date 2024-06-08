using MementoDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern.Services
{
    public class Originator<T>
    {
        public T State { get; set; }

        public Memento<T> SaveState()
        {
            return new Memento<T>(State);
        }

        public void RestoreState(Memento<T> memento)
        {
            State = memento.State;
        }
    }
}
