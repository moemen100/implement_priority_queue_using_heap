using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Queue
{
    class priority_queue
    {
        heap h=new heap();
        List<Node> nodes =new List<Node>();
        public priority_queue()
        {

        }
        public void enqueue(object value, int priority)
        {
     
            h.insert(new Node(value,priority));

        }
        public object dequeue()
        {

               
            try
            { return h.maxheap().value; }
            catch(NullReferenceException)
            {
                return -1;
            }
           
        }


    }
}
