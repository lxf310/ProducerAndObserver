using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            var producer = new Producer(queue);
            var consumer = new Consumer(queue);

            var t1 = new Thread(
               () => {
                   producer.Produce();
               });
            t1.Start();

            var t2 = new Thread(
               () => {
                   consumer.Consume();
               });
            t2.Start();

            Console.ReadLine();
        }
    }
}
