using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeCentricTree_Demo
{
    /// <summary>
    /// Node-centric implementation of a BinarySearchTree node.
    /// The main program contains the root node, and sets all references
    /// to left and right children there. 
    /// </summary>
    internal class BinaryTreeNode
    {
        // Data in the node
        private int data;

        // References to children
        private BinaryTreeNode leftChild;
        private BinaryTreeNode rightChild;

        public BinaryTreeNode LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        public BinaryTreeNode RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }

        /// <summary>
        /// Creates a BinaryTreeNode object with data.  
        /// No references to left or right children yet, as we don't know if there are right or
        /// left children.
        /// </summary>
        /// <param name="data">Data in the node</param>
        public BinaryTreeNode(int data)
        {
            this.data = data;
            leftChild = null!;
            rightChild = null!;
        }

        /// <summary>
        /// Visit all nodes in in-order traversal.
        /// </summary>
        public void PrintInOrder()
        {
            // Traverse left if there is a left child
            if(leftChild != null) 
                leftChild.PrintInOrder();

            // Current node's data
            Console.WriteLine(data);

            // Traverse right if there is a right child
            if(rightChild != null) 
                rightChild.PrintInOrder();
        }
    }
}
