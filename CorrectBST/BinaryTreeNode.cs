using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectBST
{
    class BinaryTreeNode
    {
        int data;
        BinaryTreeNode leftNode;
        BinaryTreeNode rightNode;

        public BinaryTreeNode() { }

        public void SetData(int data) {
            this.data = data;
        }

        public void SetLeftNode(BinaryTreeNode binaryTreeNode) {
            leftNode = binaryTreeNode;
        }

        public void SetRightNode(BinaryTreeNode binaryTreeNode) {
            rightNode = binaryTreeNode;
        }

        public int GetData() {
            return data;
        }

        public BinaryTreeNode GetLeftNode() {
            return leftNode;
        }

        public BinaryTreeNode GetRightNode() {
            return rightNode;
        }
    }
}
