public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
        if (x < 10)
            return true;
        for (int right = 0, left = getPow(x); right <= left; right++, left--) {
            if (getDigit(x, right) != getDigit(x, left))
                return false;
        }
        return true;
    }
    
    private int getDigit(int x, int pow) {
        return (x / (int)Math.Pow(10, pow)) % 10;
    }
    
    private int getPow(int x) {
        int counter = 0;
        while (x >= 10) {
            counter++;
            x /= 10;
        }
        return counter;
    }
}