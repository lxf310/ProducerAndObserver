using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerPattern
{
    public class Producer
    {
        private readonly Queue<int> _queue;
        private readonly object _lock = new object();

        public Producer(Queue<int> queue)
        {
            _queue = queue;
        }

        public void Produce()
        {
            lock (_lock)
            {
                Console.WriteLine($"Produced 0.");
                _queue.Enqueue(0);
                Monitor.Pulse(_lock); //Notifies a thread in the waiting queue of a change in the locked object's state.
            }
        }
    }
}
