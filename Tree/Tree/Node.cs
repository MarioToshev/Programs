using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Node 
    {
        public Node(int value)
        {

            this.Value = value;

        }

        public int Value { get; set; } = 0;
        public Node left { get; set; } = null;
        public Node right { get; set; } = null;
        public int interval { get; set; }
        public void Print()
        {
           
            Console.WriteLine($"{Value}  {interval}");
            interval++;
            if (left != null )
            {
                
                left.Print();
                
            }
             if (right!= null)
             {
                right.Print();
             }
            if (left == null && right == null)
            {
                return;
            }

        }

        internal void Insert(int data)
        {
            if (data >= Value)
            {
                if (right == null)
                {
                    right = new Node(data);
                }
                else
                {
                    right.Insert(data);
                }
            }
            else
            {
                if (left == null)
                {
                    left = new Node(data);
                }
                else
                {
                    left.Insert(data);
                }
            }
        }
    }
}
