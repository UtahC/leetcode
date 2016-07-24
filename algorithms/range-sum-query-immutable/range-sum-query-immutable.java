public class NumArray {
    int[] nums;
    public NumArray(int[] nums) {
        this.nums = nums.clone();
    }

    public int sumRange(int i, int j) {
        int sum = 0;
        for (;i <= j; i++) {
            sum += nums[i];
        }
        return sum;
    }
}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.sumRange(0, 1);
// numArray.sumRange(1, 2);