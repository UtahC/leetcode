public class Solution {
    public void moveZeroes(int[] nums) {
        int sortedPosition = nums.length;
        for (int i = 0; i < sortedPosition; i++) {
            if (nums[i] == 0 && i < sortedPosition - 1) {
                for (int j = i; j < sortedPosition - 1; j++) {
                    swap(nums, j, j + 1);
                }
                sortedPosition--;
                i--;
            }
        }
    }
    
    private void swap(int[] nums, int index1, int index2) {
        int temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = temp;
    }
}