public class Solution {
    public int[] CountBits(int num) {
        int[] result = new int[num + 1];
        for (int i = 0; i <= num; i++) {
            var ca = Convert.ToString(i, 2).ToCharArray();
            result[i] = ca.Count(e => e == '1');
        }
        return result;
    }
}