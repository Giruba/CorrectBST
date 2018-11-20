# CorrectBST
C# program to correct a BST where two nodes are swapped


Logic
-------
Simple Inorder Traversal shows whether the BST has incorrect nodes.

Whenver previous node's value is greater than the current node's value, save the nodes as first and second

If another previous node's value is greater than the current node's value, save the current node as third.

Since only two nodes are swapped, there are two conditions that arise:

  i) Condition 1:
        If two adjacent nodes are swapped, then only once a scenario is encountered where previous node's value is greater than
        the current node's value
        
  ii) Condition 2:
      If two non-adjacent nodes are swapped then  twice the Condition 1 is encountered.
      Save only the current node in the second time as 'Third Node'
      
      
      Now, at the end, if condition 1 was only encountered, swap first and second nodes.
      If condition 2 is encountered, swap first and third nodes.
      
      
  Example1:  10 20 30 40 50
             Swapping 20 and 30:   10 30 20 40 50
             Anything right of 20 is greater than it.
             On the left we have only one node 30 which is greater than 20
             
             So , Example1 falls under Condition1
             
  Example2:
          10 20 30 40 50
          Swapping 20 and 40: 10 40 30 20 50
          Now, we see than there is imbalance after 10
          So this comes under Condition2
