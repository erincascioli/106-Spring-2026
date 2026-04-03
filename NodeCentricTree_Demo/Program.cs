// Erin Cascioli
// 4/1/26
// Demo: Node-centric tree (tree built from a collection of nodes
//       without a Tree class.

namespace NodeCentricTree_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // All trees start with the root
            BinaryTreeNode root = new BinaryTreeNode(64);

            // Instantiate the other nodes in the tree
            BinaryTreeNode left = new BinaryTreeNode(23);
            BinaryTreeNode right = new BinaryTreeNode(79);
            BinaryTreeNode leftLeft = new BinaryTreeNode(15);

            // Set all references to build the tree
            root.LeftChild = left;
            root.RightChild = right;
            left.LeftChild = leftLeft;

            // All methods in the node-centric approach start at the root
            root.PrintInOrder();
        }
    }
}
