using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var obA = new Observer("A");
            subject.AddObserver(obA);
            var obB = new Observer("B");
            subject.AddObserver(obB);
            var obC = new Observer("C");
            subject.AddObserver(obC);

            for(var i  = 0;  i < 5; i++)
            {
                subject.Notify(i);
            }

            Console.ReadLine();
        }
    }
}
