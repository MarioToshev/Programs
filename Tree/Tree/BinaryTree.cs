using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class BinaryTree<T>
    {
        public T Value { get; set; }
        public Node root { get; set; }
        public List<Node> Children { get; private set; }

        public BinaryTree()
        {

            Children = new List<Node>();
        }



        public void Insert(int value)
        {
            if (root != null)
            {
                root.Insert(value);
            }
            else
            {
                root = new Node(value); 
            }
           
        }


        public void Print()
        {

            root.Print();
      
        }
    }
}
