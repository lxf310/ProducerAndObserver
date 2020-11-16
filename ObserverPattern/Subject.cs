using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject
    {
        private readonly HashSet<Observer> _observers = new HashSet<Observer>();

        public string Message { get; private set; }

        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(int i)
        {
            Message = $"This is message {i}.";
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
