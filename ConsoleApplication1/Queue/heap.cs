namespace ConsoleApplication1.Queue
{
    class heap
    {        
        private Node[] nodes;      
        public heap()
        {
            //nodes = new Node[20];
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
             // delete last node               
                if (i <= 0)
                    return null;
                if (i == 1)
                    return  temp;
            count++;
            nodes[1] = nodes[i];
            nodes[i] = null;           
            while (j < count)
            {
                i = j;   
                if (2 * i < count)
                {    if (nodes[2 * i] != null)// if node it have left child
                    {                        
                        if (nodes[2 * i].priority >nodes[i].priority|| (nodes[2 * i].priority == nodes[i ].priority && nodes[2 * i].no < nodes[ i].no)) //compare left node with parent
                        {
                            if (2 * i + 1 < count)
                            {
                                if (nodes[2 * i + 1] != null)
                                {
                                    if (nodes[2 * i].priority > nodes[2 * i + 1].priority || (nodes[2 * i].priority == nodes[2 * i + 1].priority && nodes[2 * i].no < nodes[2 * i + 1].no))
                                    {

                                        max = nodes[2 * i];
                                        nodes[2 * i] = nodes[i];

                                        nodes[i] = max;
                                        j = 2 * i;
                                    }
                                    else
                                    {
                                        max = nodes[2 * i + 1];
                                        nodes[2 * i + 1] = nodes[i];
                                        nodes[i] = max;
                                        j = 2 * i + 1;
                                    }
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
                    }
                }
                if (2 * i + 1 < count)
                {
                    if (i == j)
                    {
                        if (nodes[2 * i + 1] != null)
                        {
                            if (nodes[2 * i + 1].priority > nodes[i].priority || (nodes[2 * i+1].priority == nodes[ i ].priority && nodes[2 * i+1].no < nodes[i].no))
                            {
                                max = nodes[2 * i + 1];
                                nodes[2 * i + 1] = nodes[i];
                                nodes[i] = max;
                                j = 2 * i + 1;
                            }
                        }
                    }
                }
                if (i == j)
                    j = count;                
            }           
            return temp;
        }
        public void insert(Node n, int i)
        {
            Node temp;
            if (nodes==null||nodes.Length == 0)
            {
                nodes = new Node[ 2];
                nodes[1] = n;
                return;
            }
            if (i >= nodes.Length)// it will reserve double the capcity of nodes when the nodes are fully reserved 
            {
                // System.Diagnostics.Debug.WriteLine("Length="+nodes.Length);
                Node[] newnodes;
                newnodes = new Node[i *2];
                nodes.CopyTo(newnodes, 0);
                nodes = newnodes;
            }
            nodes[i] = n;
            int j;                                
            while (i > 1)
            {
                j = i;   
                if (i % 2 == 0)
                {
                   
                    if (nodes[i].priority > nodes[i / 2].priority) //check if the parent had per >left child
                    {
                        temp = nodes[i / 2];
                        nodes[i / 2] = nodes[i];
                        nodes[i] = temp;
                        i = i / 2;
                    }
                   
                }
                else
                {
                    
                    if (nodes[i].priority > nodes[(i-1) / 2].priority) //check if the parent has per >right child per
                    {
                        temp = nodes[i / 2];
                        nodes[i / 2] = nodes[i];
                        nodes[i] = temp;
                        i = (i - 1) / 2;
                    }                    
                }
                if (j == i)
                    i = 0;
            }                        
        }
    }
}
