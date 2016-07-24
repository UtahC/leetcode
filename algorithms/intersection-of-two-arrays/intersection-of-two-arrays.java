

public class Solution {
    public int[] intersection(int[] nums1, int[] nums2) {
        HashSet<Integer> result = new HashSet<Integer>();
        for (int i = 0; i < nums1.length; i++) {
            for (int j = 0; j < nums2.length; j++) {
                if (nums1[i] == nums2[j]) {
                    result.add(nums1[i]);
                }
            }
        }
        int[] array = new int[result.size()];
        Iterator iterator = result.iterator();
        int counter = 0;
        while (iterator.hasNext()) {
            array[counter] = (int)iterator.next();
            counter++;
        }
        return array;
    }
}