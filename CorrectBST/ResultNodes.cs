using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectBST
{
    class ResultNodes
    {
        BinaryTreeNode firstIncorrectNode;
        BinaryTreeNode secondIncorrectNode;
        BinaryTreeNode thirdIncorrectNode;
        BinaryTreeNode previousNode;

        public ResultNodes() { }

        public void SetPreviousNode(BinaryTreeNode binaryTreeNode) {
            previousNode = binaryTreeNode;
        }

        public void SetFirstNode(BinaryTreeNode binaryTreeNode){
            firstIncorrectNode = binaryTreeNode;
        }

        public void SetSecondNode(BinaryTreeNode binaryTreeNode) {
            secondIncorrectNode = binaryTreeNode;
        }

        public void SetThirdNode(BinaryTreeNode binaryTreeNode) {
            thirdIncorrectNode = binaryTreeNode;
        }

        public BinaryTreeNode GetFirstNode() {
            return firstIncorrectNode;
        }

        public BinaryTreeNode GetSecondNode() {
            return secondIncorrectNode;
        }

        public BinaryTreeNode GetThirdNode() {
            return thirdIncorrectNode;
        }

        public BinaryTreeNode GetPreviousNode() {
            return previousNode;
        }
    }
}
