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
    
    private IList<string> list = new List<string>();
    
    public IList<string> BinaryTreePaths(TreeNode root) {
        getResult(root, "");
        return list;
    }
    
    private void getResult(TreeNode root, string str) {
        if (root == null)
            return;
        if (str == "")
            str = root.val.ToString();
        else
            str = str + "->" + root.val;
        if (root.left == null && root.right == null) {
            list.Add(str);
        }
        getResult(root.left, str);
        getResult(root.right, str);
    }
}