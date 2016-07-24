public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (k <= 0)
            return false;
        var set = new HashSet<int>(nums);
        if (set.Count == nums.Length)
            return false;
        for (int i = 0; i < nums.Length; i++) {
            int leftBoundary = i - k < 0 ? 0 : i - k;
            int rightBoundary = i + k > nums.Length - 1 ? nums.Length - 1 : i + k;
            if (Array.IndexOf(nums, nums[i], leftBoundary, i - leftBoundary) >= 0)
                return true;
            if (Array.IndexOf(nums, nums[i], i + 1, rightBoundary - i) >= 0)
                return true;
        }
        return false;
    }
}