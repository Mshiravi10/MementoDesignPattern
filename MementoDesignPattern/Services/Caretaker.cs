using MementoDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern.Services
{
    public class Caretaker<T>
    {
        private readonly List<Memento<T>> _undoMementos = new List<Memento<T>>();
        private readonly List<Memento<T>> _redoMementos = new List<Memento<T>>();
        private readonly Originator<T> _originator;

        public Caretaker(Originator<T> originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            _undoMementos.Add(_originator.SaveState());
            _redoMementos.Clear(); 
        }

        public void Undo()
        {
            if (_undoMementos.Count == 0) return;

            var memento = _undoMementos[^1];
            _undoMementos.RemoveAt(_undoMementos.Count - 1);
            _redoMementos.Add(_originator.SaveState());
            _originator.RestoreState(memento);
        }

        public void Redo()
        {
            if (_redoMementos.Count == 0) return;

            var memento = _redoMementos[^1];
            _redoMementos.RemoveAt(_redoMementos.Count - 1);
            _undoMementos.Add(_originator.SaveState());
            _originator.RestoreState(memento);
        }
    }
}
