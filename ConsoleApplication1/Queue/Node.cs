﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Queue
{
    class Node
    {
        
        public object value { get; }
        public int priority { get; }
        public int no { get; }

        public Node (object value ,int priority,int no)
        {
            this.value = value;
            this.priority=priority;
            this.no = no;
        }
        

    }
}
