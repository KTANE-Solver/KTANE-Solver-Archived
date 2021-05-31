using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    //Date: 5/30/21
    //Purpose: A class needed to create a binary tree
    class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root
        { get; set; }

        public BinaryTree(T data)
        {
            Root = new BinaryTreeNode<T>(data);
        }
    }
}
