using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern.Models
{
    public class Memento<T>
    {
        public T State { get; private set; }

        public Memento(T state)
        {
            State = state;
        }
    }
}
