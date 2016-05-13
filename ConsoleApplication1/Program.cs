using ConsoleApplication1.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            priority_queue p= new priority_queue();
            p.enqueue("test", 2);
            p.enqueue(7, 6);
            p.enqueue(6, 5);
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            p.enqueue(11, -1);
            p.enqueue(5, 5);
            p.enqueue(4, 5);
            p.enqueue("test1", 2);
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            p.enqueue(3, 5);
            p.enqueue('t', 4);
            p.enqueue(22, 2);
            p.enqueue(21, 2);
            p.enqueue('u', 4);
            p.enqueue(20, 2);
            p.enqueue("test8", 0);
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());

            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue()); // it will return -1 when no more items in queue
            



        }
    }
}
