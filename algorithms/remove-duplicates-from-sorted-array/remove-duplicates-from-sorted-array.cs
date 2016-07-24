public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 1)
            return nums.Length;

        int cur = 0;
        int runner = 0;
        while (runner < nums.Length)
        {
            if (nums[cur] == nums[runner])
            {
                runner++;
                continue;
            }
            nums[++cur] = nums[runner];
        }
        return cur + 1;
    }
}