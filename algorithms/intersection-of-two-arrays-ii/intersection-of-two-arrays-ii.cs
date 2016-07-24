public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if (nums1.Length < nums2.Length)
            swap(nums1, nums2);
        var result = new List<int>();
        var numsList1 = nums1.ToList();
        var numsList2 = nums2.ToList();
        for (int i = 0; i < numsList1.Count; i++) {
            int index = numsList2.IndexOf(numsList1[i]);
            if (index == -1)
                continue;
            result.Add(numsList1[i]);
            numsList2.RemoveAt(index);
        }
        return result.ToArray();
    }
    
    private void swap (int[] nums1, int[] nums2) {
        var temp = nums1;
        nums1 = nums2;
        nums2 = temp;
    }
}