public class Solution {
    private Dictionary<int, int> dic = new Dictionary<int, int>();
    public int Rob(int[] nums) {
        if (nums.Length == 0)
            return 0;
        else if (nums.Length == 1)
            return nums[0];
        dic.Add(0, nums[0]);
        dic.Add(1, nums[0] < nums[1] ? nums[1] : nums[0]);
        return maxMoney(nums, nums.Length - 1);
    }
    
    private int maxMoney(int[] nums, int index) {
        if (dic.ContainsKey(index))
            return dic[index];
        
        var left1 = maxMoney(nums, index - 1);
        dic[index - 1] = left1;
        var left2 = maxMoney(nums, index - 2);
        dic[index - 2] = left2;
        if (left1 > left2 + nums[index])
            return left1;
        else
            return left2 + nums[index];
    }
}