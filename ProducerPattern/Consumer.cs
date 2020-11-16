using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerPattern
{
    public class Consumer
    {
        private readonly Queue<int> _queue;
        private readonly object _lock = new object();

        public Consumer(Queue<int> queue)
        {
            _queue = queue;
        }

        public void Consume()
        {
            lock (_lock)
            {
                while (!_queue.Any())
                {
                    Monitor.Wait(_lock);
                }

                var i = _queue.Dequeue();
                Console.WriteLine($"Consuming {i}.");
            }
        }
    }
}
