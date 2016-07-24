public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var nList = new List<int>(nums);
        var nSet = new HashSet<int>(nums);
        if (nList.Count == nSet.Count)
            return false;
        return true;
    }
}