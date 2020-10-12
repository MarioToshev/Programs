using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();

            tree.Insert(17);
            tree.Insert(19);
            tree.Insert(9);
            tree.Insert(12);
            tree.Insert(6);
            tree.Insert(25);


            tree.Print();




        }
    }
}
