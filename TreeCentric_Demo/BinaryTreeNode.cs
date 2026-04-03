using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCentric_Demo
{
    internal class BinaryTreeNode
    {
        // Binary tree nodes have a left and right child
        private BinaryTreeNode left;
        private BinaryTreeNode right;

        // Binary tree nodes contain data
        private int data;

        /// <summary>
        /// Set and get the left child
        /// </summary>
        public BinaryTreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        /// <summary>
        /// Set and get the right child
        /// </summary>
        public BinaryTreeNode Right
        {
            get { return right; }
            set { right = value; }
        }

        /// <summary>
        /// Set and get the data
        /// </summary>
        public int Data
        {
            get { return data; }
        }

        /// <summary>
        /// Instantiate a new node
        /// </summary>
        /// <param name="data">Data in the node</param>
        public BinaryTreeNode(int data)
        {
            this.data = data;
            left = null!;
            right = null!;
        }
    }
}
