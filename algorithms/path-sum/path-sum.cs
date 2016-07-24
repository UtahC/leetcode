/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        bool left = false, right = false;
        if (root == null)
            return false;
        if (root.left != null)
            left = HasPathSum(root.left, sum - root.val);
        if (root.right != null)
            right = HasPathSum(root.right, sum - root.val);
        bool val = ((sum - root.val == 0) && root.left == null && root.right == null);
        return left || right || val;
    }
}