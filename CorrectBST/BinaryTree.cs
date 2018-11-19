using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectBST
{
    class BinaryTree
    {
        BinaryTreeNode rootNode;

        public BinaryTree() { }

        public BinaryTreeNode GetRootNode() {
            return rootNode;
        }

        public void SetRootNode(BinaryTreeNode binaryTreeNode) {
            rootNode = binaryTreeNode;
        }

        public void Insert(int data) {
            rootNode = _InsertUtil(rootNode, data);
        }

        private BinaryTreeNode _InsertUtil(BinaryTreeNode binaryTreeNode, int data) {

            if (binaryTreeNode == null) {
                binaryTreeNode = new BinaryTreeNode();
                binaryTreeNode.SetData(data);
                return binaryTreeNode;
            }

            //Right Insertion
            if (binaryTreeNode.GetData() < data){
                binaryTreeNode.SetRightNode(
                    _InsertUtil(binaryTreeNode.GetRightNode(), data));
            }
            else {
                binaryTreeNode.SetLeftNode(
                    _InsertUtil(binaryTreeNode.GetLeftNode(), data));
            }

            return binaryTreeNode;
        }
    }
}
