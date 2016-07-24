public class Solution {
    public bool IsPowerOfTwo(int n) {
        for (int i = 0; Math.Pow(2, i) <= n; i++) {
            if (Math.Pow(2, i) == n)
                return true;
        }
        return false;
    }
}