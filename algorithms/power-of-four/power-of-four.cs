public class Solution {
    public bool IsPowerOfFour(int num) {
        if (num <= 0)
            return false;
        while (num > 1) {
            if (num % 4 != 0)
                return false;
            num >>= 2;
        }
        if (num == 1)
            return true;
        return false;
    }
}