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
    int depth = 0;
    public int maxDepth(TreeNode root) {
        int lDepth = 0, rDepth = 0;
        if (root == null)
            return 0;
        if (root.left != null)
            lDepth = maxDepth(root.left) + 1;
        if (root.right != null)
            rDepth = maxDepth(root.right) + 1;
        if (root.left == null && root.right == null)
            return 1;
        int result = lDepth >= rDepth ? lDepth : rDepth;
        return result;
    }
}