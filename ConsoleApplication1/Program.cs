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
            p.enqueue("test1",2);
            p.enqueue('t', 4);
            p.enqueue(4, 5);
            p.enqueue("test8", 0);
            p.enqueue(5, -1);
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            System.Diagnostics.Debug.WriteLine(p.dequeue());
            


        }
    }
}
