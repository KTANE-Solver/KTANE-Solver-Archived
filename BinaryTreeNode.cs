using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    //Date: 5/30/21
    //Purpose: A class needed to create a binary tree
    class BinaryTreeNode<T>
    {
        //the data the node will hold
        public T Data
        { get; set; }

        //the left node
        public BinaryTreeNode<T> LeftNode
        { get; set; }

        //the right node
        private BinaryTreeNode<T> RightNode
        { get; set; }


        /// <summary>
        /// Creates a node
        /// </summary>
        /// <param name="data">the dta the node will hold</param>
        public BinaryTreeNode (T data)
        {
            Data = data;
            LeftNode = null;
            RightNode = null;
        }
    }
}
