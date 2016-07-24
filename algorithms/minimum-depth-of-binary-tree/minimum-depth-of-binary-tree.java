/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int minDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int leftMin = minDepth(root.left);
        int rightMin = minDepth(root.right);
        if (root.left == null && root.right == null){
            return 1;
        }
        else if (root.left == null) {
            leftMin = Integer.MAX_VALUE;
        }
        else if (root.right == null) {
            rightMin = Integer.MAX_VALUE;
        }
        return Math.min(leftMin, rightMin) + 1;
            
        
    }
}