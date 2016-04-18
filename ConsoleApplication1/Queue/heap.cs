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
        public Node maxheap()//Node[] nodes)
        { Node temp;
            Node max;
            int i = 0;
            int j = 1;
            if (nodes == null || nodes.Count() == 0)
            {
                return null;
            }
            if (nodes[1] == null)
                return null;
            temp = nodes[1];
            nodes[1] = null;
            while (nodes[1] == null) // delete last node 
            {
                i++;
                nodes[1] = nodes[nodes.Length-i];
                if (i > nodes.Length)
                    return null;
                if (i == nodes.Length)
                    return temp;
                
               
            }
           
            nodes[nodes.Length-i] = null;


            while (j < nodes.Count())

            {

                max = nodes[j];
                i = j;
                if (2 * i < nodes.Count())
                {    if (nodes[2 * i] != null)// if node it have left child
                    {
                        
                        if (nodes[2 * i].priority > nodes[i].priority) //compare left node with parent
                        {
                            if (2 * i + 1 < nodes.Count())
                                if (nodes[2 * i + 1] != null)
                                {
                                    if (nodes[2 * i].priority >= nodes[2 * i + 1].priority)
                                    {
                                        max = nodes[2 * i];
                                        nodes[2 * i] = nodes[i];
                                        j = 2 * i;

                                    }


                                }
                                else
                                {
                                    max = nodes[2 * i];
                                    nodes[2 * i] = nodes[i];
                                    j = 2 * i;
                                }
                           
                            if (nodes[2 * i+1] != null)
                                if (nodes[2 * i].priority < nodes[2 * i + 1].priority)
                            {

                                max = nodes[2 * i + 1];
                                nodes[2 * i + 1] = nodes[i];
                                j = 2 * i + 1;
                            }
                            nodes[i] = max;
                           

                        }
                       
                    }

                    
                }
                if (nodes[2 * i+1] != null)
                {
                    if (nodes[2 * i].priority < nodes[i].priority)
                    {

                        if (2 * i + 1 < nodes.Count())
                        {
                            if (nodes[2 * i + 1] != null)
                            {
                                if (nodes[2 * i + 1].priority > nodes[i].priority)
                                {
                                    max = nodes[2 * i + 1];
                                    nodes[2 * i + 1] = nodes[i];
                                    nodes[i] = max;
                                    j = 2 * i + 1;
                                }
                                else
                                {
                                    j = nodes.Count();
                                }

                            }

                        }

                    }
                    else
                    {
                        j = nodes.Count();
                    }
                }
                else j = nodes.Count();
                if (2 * i + 1 > nodes.Count())
                    j = nodes.Count();

                

            }

           

            return temp;
        }
        public void insert(Node n)
        {

            Node[] newnodes;
            if (nodes==null||nodes.Length == 0)
            {
                newnodes = new Node[ 2];
                newnodes[1] = n;
                nodes = newnodes;
                return;
            }
            
            newnodes = new Node[nodes.Length + 1];
            nodes.CopyTo(newnodes, 0);
            int i;
            Node temp;
            newnodes[nodes.Length ] = n;
            i = newnodes.Count()-1;
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
                    
                    if (newnodes[i].priority > newnodes[(i-1) / 2].priority) //check if the parent had per >right child
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
