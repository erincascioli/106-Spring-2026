// Erin Cascioli
// 4/3/26
// Demo: Dynamic ("smart" "tree-centric") Binary Tree

namespace TreeCentric_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tree starts with no data
            BinaryTree myTree = new BinaryTree();

            // Add some values into the tree
            myTree.Add(100);
            myTree.Add(50);
            myTree.Add(150);
            myTree.Add(25);
            myTree.Add(50);
            myTree.Add(75);
            myTree.Add(198);

            // Find the smallest value in the tree
            Console.WriteLine(myTree.FindMinRecursive());

            // NOPE!
            //Console.WriteLine(myTree.FindMinRecursive(myTree.Root));
        }
    }
}
