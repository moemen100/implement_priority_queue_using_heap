using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Queue
{
    class heap
    {
        
        private Node[] nodes;      
        public heap()
        {
          
            
        }
        public  Node maxheap(int i)//i is the index of  last item it i passed to avoid a loop for deleting last element
        { Node temp;
            Node max;

            int count;
            count = i;
            int j = 1;
            if (nodes == null || count == 0)
            {
                return null;
            }
            if (nodes[1] == null)
                return null;
            temp = nodes[1];
            //nodes[1] = null;
             // delete last node 
               
                if (i <= 0)
                    return null;
                if (i == 1)
                    return  temp;
            nodes[1] = nodes[i];
            nodes[i] = null;
            
            { Console.Write("\n"+ nodes.Length + "->" +i); }

            while (j < count)

            {

                max = nodes[j];
                i = j;
                if (2 * i < count)
                {    if (nodes[2 * i] != null)// if node it have left child
                    {
                        
                        if (nodes[2 * i].priority >=nodes[i].priority) //compare left node with parent
                        {
                            if (2 * i + 1 < count)
                            {
                                if (nodes[2 * i + 1] != null)
                                {
                                    if (nodes[2 * i].priority >= nodes[2 * i + 1].priority)
                                    {
                                        max = nodes[2 * i];
                                        nodes[2 * i] = nodes[i];
                                        
                                        nodes[i] = max;
                                        j = 2 * i;

                                    }


                                }
                                else
                                {
                                    max = nodes[2 * i];
                                    nodes[2 * i] = nodes[i];
                                    nodes[i] = max;
                                    j = 2 * i;
                                }
                            }
                       if(2 * i + 1<count)
                         if (nodes[2 * i+1] != null)
                            if (nodes[2 * i].priority < nodes[2 * i + 1].priority)
                            {

                                max = nodes[2 * i + 1];
                                nodes[2 * i + 1] = nodes[i];
                                    nodes[i] = max;
                                    j = 2 * i + 1;
                            }
                           
                           

                        }
                       
                    }

                    
                }
                if (2 * i + 1 < count)
                {
                    if (nodes[2 * i + 1] != null)
                    {
                        if (nodes[2 * i].priority < nodes[i].priority)
                        {

                            if (2 * i + 1 < count)
                            {
                                if (nodes[2 * i + 1] != null)
                                {
                                    if (nodes[2 * i + 1].priority >= nodes[i].priority)
                                    {
                                        max = nodes[2 * i + 1];
                                        nodes[2 * i + 1] = nodes[i];
                                        nodes[i] = max;
                                        j = 2 * i + 1;
                                    }
                                    else
                                    {
                                        j = count;
                                    }

                                }
                                else
                                {
                                    j = count;
                                }

                            }
                            else
                            {
                                j = count;
                            }

                        }
                        else
                        {
                            j = count;
                        }
                    }
                    else
                    {
                        j = count;
                    }
                }
                else j = count;
                if (2 * i + 1 > count)
                    j = count;

                

            }


           
           
            return temp;
        }
        public void insert(Node n, int i)
        {
            
            
            Node[] newnodes;
            if (nodes==null||nodes.Length == 0)
            {
                newnodes = new Node[ 2];
                newnodes[1] = n;
                nodes = newnodes;
                return;
            }
            
            newnodes = new Node[i + 1];
            nodes.CopyTo(newnodes, 0);
            newnodes[i] = n;
            
           
           
            Node temp;
           

            while (i > 1)
            {
                
                if (i % 2 == 0)
                {
                   
                    if (newnodes[i].priority > newnodes[i / 2].priority) //check if the parent had per >left child
                    {
                        temp = newnodes[i / 2];
                        newnodes[i / 2] = newnodes[i];
                        newnodes[i] = temp;
                        i = i / 2;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                else
                {
                    
                    if (newnodes[i].priority > newnodes[(i-1) / 2].priority) //check if the parent has per >right child per
                    {
                        temp = newnodes[i / 2];
                        newnodes[i / 2] = newnodes[i];
                        newnodes[i] = temp;
                        i = (i - 1) / 2;
                    }
                    else
                    {
                        i = 0;
                    }

                    
                }

            }
          
            nodes = newnodes;
        }

        

    }
}
