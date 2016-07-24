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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<TreeNode>> tree = new List<IList<TreeNode>>();
        IList<TreeNode> row = new List<TreeNode>() { root };
        tree.Add(row);
        IList<IList<int>> numTree = new List<IList<int>>();
        if (root == null)
            return numTree;
        IList<int> numRow = new List<int>() { root.val };
        numTree.Add(numRow);
        while (true) {
            row = new List<TreeNode>();
            numRow = new List<int>();
            (tree.LastOrDefault() as List<TreeNode>).ForEach(n => {
                if (n != null) {
                    if (n.left != null) {
                        row.Add(n.left);
                        numRow.Add(n.left.val);
                    }
                    if (n.right != null) {
                        row.Add(n.right);
                        numRow.Add(n.right.val);
                    }
                }
            });
            if (row.Count <= 0)
                break;
            tree.Add(row);
            numTree.Add(numRow);
        }
        return numTree;
    }
}