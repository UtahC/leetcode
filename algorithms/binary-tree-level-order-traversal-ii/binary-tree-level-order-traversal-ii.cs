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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var nodeList = new List<List<TreeNode>>();
        var list = new List<TreeNode>();
        list.Add(root);
        nodeList.Add(list);
        while(true) {
            list = new List<TreeNode>();
            nodeList.LastOrDefault().ForEach(l => 
            {
                if (l != null) 
                {
                    if (l.left != null)
                        list.Add(l.left);
                    if (l.right != null)
                        list.Add(l.right);
                }
            });
            if (list.Count() == 0)
                break;
            nodeList.Add(list);
        }
        IList<IList<int>> result = new List<IList<int>>();
        
        nodeList.ForEach(l => 
        {
            if (l != null)
            {
                IList<int> numList = new List<int>();
                l.ForEach(n => 
                {
                    if (n != null)
                        numList.Add(n.val);
                });
                if (numList.Count != 0)
                    result.Insert(0, numList);
            }
        });
        return result;
    }
}