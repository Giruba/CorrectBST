using System;

namespace CorrectBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Correct a BST whose two nodes are swapped!");
            Console.WriteLine("------------------------------------------");

            BinaryTree binaryTree = ConstructTree();
            try
            {

                Console.WriteLine("The input BST----------");
                TreeUtility.PrintTree(binaryTree.GetRootNode());
                Console.WriteLine();
                binaryTree = TreeUtility.ModifyTree(binaryTree);
                Console.WriteLine();
                TreeUtility.CorrectBST(binaryTree.GetRootNode());
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            Console.ReadLine();
        }

        private static BinaryTree ConstructTree() {

            BinaryTree binaryTree = null;
            Console.WriteLine("Enter the number of elements for Binary Search Tree construction");
            try{
                int noOfElements = int.Parse(Console.ReadLine());
                binaryTree = new BinaryTree();
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                for (int i = 0; i < noOfElements; i++) {
                    binaryTree.Insert(int.Parse(elements[i]));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return binaryTree;
        }        
    }
}
