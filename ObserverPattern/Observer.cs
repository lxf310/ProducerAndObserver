using System;

namespace ObserverPattern
{
    public class Observer
    {
        public string Name { get; private set; }

        public Observer(string name)
        {
            Name = name;
        }

        public void Update(Subject subject)
        {
            Console.WriteLine($"Oberserver {Name} is processing \"{subject.Message}\"");
        }
    }
}
