public class Solution {
    public int MajorityElement(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            int count = nums.Count(e => e == nums[i]);
            if (count > nums.Length / 2)
                return nums[i];
            nums = nums.Where(e => e != nums[i]).ToArray();
        }
        return -1;
    }
}