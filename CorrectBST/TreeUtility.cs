using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectBST
{
    static class TreeUtility
    {
        static BinaryTreeNode previousNode = null;
        public static void CorrectBST(BinaryTreeNode binaryTreeNode){
            ResultNodes resultNodes = new ResultNodes();
            resultNodes = _CorrectBSTUtil(binaryTreeNode, resultNodes);
            if (resultNodes == null)
            {
                Console.WriteLine("The entered Binary Search Tree is correct! No incorrect nodes found!");
            }
            else {
                if (resultNodes.GetThirdNode() != null)
                {
                    binaryTreeNode = SwapAndRectify(binaryTreeNode, resultNodes.GetFirstNode(), resultNodes.GetThirdNode());
                    
                }
                else {

                    binaryTreeNode = SwapAndRectify(binaryTreeNode, resultNodes.GetFirstNode(), resultNodes.GetSecondNode());
                }
                Console.WriteLine("-----Printing the rectified tree!---------");
                PrintTree(binaryTreeNode);
            }

        }

        private static BinaryTreeNode SwapAndRectify(BinaryTreeNode rootNode, BinaryTreeNode node1, BinaryTreeNode node2) {

            int value1 = node1.GetData();
            int value2 = node2.GetData();

            rootNode = Rectify(rootNode, value1, value2);
            //previousNode = null;
            //return Rectify(rootNode, value2, value1);
            return rootNode;
        }

        private static ResultNodes _CorrectBSTUtil(BinaryTreeNode binaryTreeNode, ResultNodes resultNodes) {

            if (binaryTreeNode == null) {
                return resultNodes;
            }

            resultNodes = _CorrectBSTUtil(binaryTreeNode.GetLeftNode(), resultNodes);

            if (resultNodes != null &&
                resultNodes.GetPreviousNode() != null &&
                    resultNodes.GetPreviousNode().GetData() > binaryTreeNode.GetData()) {

                if (resultNodes.GetFirstNode() == null)
                {
                    resultNodes.SetFirstNode(resultNodes.GetPreviousNode());
                    resultNodes.SetSecondNode(binaryTreeNode);
                }
                else {
                    resultNodes.SetThirdNode(binaryTreeNode);
                }
            }

            if (resultNodes != null)
            {
                resultNodes.SetPreviousNode(binaryTreeNode);
            }

            return _CorrectBSTUtil(binaryTreeNode.GetRightNode(), resultNodes);
        }

        private static BinaryTreeNode Rectify(BinaryTreeNode binaryTreeNode, int value1,
            int value2) {
            if (binaryTreeNode == null) {
                return null;
            }

            BinaryTreeNode leftNode = Rectify(binaryTreeNode.GetLeftNode(), value1, value2);

            if (previousNode != null
                && previousNode.GetData() > binaryTreeNode.GetData()
                && previousNode.GetData() == value1 &&
                value2 < value1)
            {
                binaryTreeNode.SetLeftNode(leftNode);
                binaryTreeNode.SetData(value1);
                previousNode.SetData(value2);
                return binaryTreeNode;
            }
            
            previousNode = binaryTreeNode;

            BinaryTreeNode right = Rectify(binaryTreeNode.GetRightNode(), value1, value2);
            binaryTreeNode.SetLeftNode(leftNode);
            binaryTreeNode.SetRightNode(right);
            return binaryTreeNode;
        }

        public static void PrintTree(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }

            //Inorder Traversal
            PrintTree(binaryTreeNode.GetLeftNode());
            Console.Write(binaryTreeNode.GetData()+"->");
            PrintTree(binaryTreeNode.GetRightNode());
        }

        public static BinaryTree ModifyTree(BinaryTree binaryTree)
        {
            if (binaryTree == null)
            {
                Console.WriteLine("Input BST is null. There is nothing to modify!");
                return null;
            }

            Console.WriteLine("Modifying Root Node with the first Node in left Tree");
            try
            {
                if (binaryTree != null)
                {
                    int value1 = binaryTree.GetRootNode() != null ?
                                binaryTree.GetRootNode().GetData() : -1;
                    int value2 = binaryTree.GetRootNode().GetLeftNode() != null ?
                        binaryTree.GetRootNode().GetLeftNode().GetData() : -1;
                    int value3 = binaryTree.GetRootNode().GetRightNode() != null ?
                        binaryTree.GetRootNode().GetRightNode().GetData() : -1;

                    if (value1 != -1 && value2 != -1)
                    {
                        binaryTree.GetRootNode().SetData(value2);
                        binaryTree.GetRootNode().GetLeftNode().SetData(value1);
                    }
                    else if (value1 != -1 && value3 != -1) {
                        binaryTree.GetRootNode().SetData(value3);
                        binaryTree.GetRootNode().GetRightNode().SetData(value1);

                    }
                    Console.WriteLine("Modified BST is -----------");
                    TreeUtility.PrintTree(binaryTree.GetRootNode());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Thrown exception is " + exception.Message);
            }
            return binaryTree;
        }
    }
}
