using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Queue
{
    class priority_queue
    {
        private int i = 0;
        private heap h=new heap();
        private List<Node> nodes =new List<Node>();
        public priority_queue()
        {

        }
        public void enqueue(object value, int priority)
        {
            i++;
            h.insert(new Node(value,priority,i),i);
           

        }
        public object dequeue()
        {

            
            try
            {
               
                var temp = h.maxheap(i).value;
                i--;
                return temp;
                
            }
            catch(NullReferenceException)
            {
                return -1;
            }
            
           
        }


    }
}
