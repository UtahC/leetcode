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
    private Dictionary<TreeNode, int> dic = new Dictionary<TreeNode, int>();
    public bool IsBalanced(TreeNode root) {
        if (root == null)
            return true;
        bool isLeft = IsBalanced(root.left);
        bool isRight = IsBalanced(root.right);
        int left = getDepth(root.left);
        int right = getDepth(root.right);
        if (Math.Abs(left - right) <= 1)
            return isLeft && isRight;
        return false;
    }
    private int getDepth(TreeNode subTreeRoot) {
        if (subTreeRoot == null)
            return 0;
        if (dic.ContainsKey(subTreeRoot))
            return dic[subTreeRoot];
        if (subTreeRoot.left == null && subTreeRoot.right == null) {
            dic.Add(subTreeRoot, 1);
            return dic[subTreeRoot];
        }

        int left = getDepth(subTreeRoot.left);
        int right = getDepth(subTreeRoot.right);
        int depth = left > right ? left : right;
        depth++;
        dic.Add(subTreeRoot, depth);
        return dic[subTreeRoot];
    }
}