using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCentric_Demo
{
    internal class BinaryTree
    {
        // Fields:
        private BinaryTreeNode root;

        // DON'T NEED THIS!!!!!!!!!
        //public BinaryTreeNode Root
        //{ 
        //    get
        //    {
        //        return root;
        //    }
        //}

        public BinaryTree()
        {
            root = null!;
        }

        /// <summary>
        /// Public-facing version starts at the root. Adds data to the binary tree.
        /// </summary>
        /// <param name="dataToAdd">Data to add to the tree</param>
        public void Add(int dataToAdd)
        {
            // No root? Make one!
            if (root == null)
                root = new BinaryTreeNode(dataToAdd);

            // There is at least one data in the tree. Start adding at the root.
            else
                Add(dataToAdd, root);
        }

        /// <summary>
        /// Private version only used within this class.
        /// </summary>
        /// <param name="dataToAdd">Data to add to the tree</param>
        /// <param name="current">Node to start at recursion</param>
        private void Add(int dataToAdd, BinaryTreeNode current)
        {
            // Compare the data to the current node's data to know whether to traverse
            //   left or right
            if(dataToAdd < current.Data)
            {
                // There is a left child, so traverse to that recursively
                if (current.Left != null)
                {
                    Add(dataToAdd, current.Left);
                }
                // There's no left node? This data becomes the new left node!
                else
                {
                    current.Left = new BinaryTreeNode(dataToAdd);
                }
            }
            // GO RIGHT
            else
            {
                // There is a left child, so traverse to that recursively
                if (current.Right != null)
                {
                    Add(dataToAdd, current.Right);
                }
                // There's no right node? This data becomes the new right node!
                else
                {
                    current.Right = new BinaryTreeNode(dataToAdd);
                }
            }
        }

        /// <summary>
        /// Returns the smallest value in the binary search tree.
        /// </summary>
        /// <returns>Smallest value in the binary tree</returns>
        /// <exception cref="Exception">When there is no data, throw an exception.</exception>
        public int FindMinimum()
        {
            if(root == null)
            {
                throw new Exception("The tree has no data yet. No min found.");
            }

            // Definition of minimum:  Left mode leaf node
            // If the root has a left child, "go to" the left child
            // Keep going until the left child has no left child
            // Retrieve the data from that node

            BinaryTreeNode current = root;
            while(root.Left != null)
            {
                current = current.Left;
            }

            // Now I'm at the left leaf!
            return current.Data;
        }

        /// <summary>
        /// Find the smallest value in the binary tree recursively
        /// </summary>
        /// <param name="current">Node to inspect</param>
        /// <returns>Smallest value in the tree</returns>
        private int FindMinRecursive(BinaryTreeNode current)
        {
            // Found the left-most leaf node
            if (current.Left == null)
                return current.Data;

            // There is a left child - call the method recursively starting at the left.
            else
                return FindMinRecursive(current.Left);
        }

        /// <summary>
        /// Public-facing starts the search at the root
        /// </summary>
        /// <returns>Returns the smallest value in the tree</returns>
        /// <exception cref="Exception">No root? Throws an exception</exception>
        public int FindMinRecursive()
        {
            // The root exists: Start there
            if (root != null)
                return FindMinRecursive(root);

            // NO root? Don't return extraneous data... throw an exception!
            else
                throw new Exception("No root node, no min.");
        }
    }
}
