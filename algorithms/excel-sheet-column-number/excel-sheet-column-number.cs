public class Solution {
    public int TitleToNumber(string s) {
        int result = 0;
        char[] ca = s.ToCharArray();
        for (int i = ca.Length - 1; i >= 0; i--) {
            result += getLetterInteger(ca[i]) * (int)Math.Pow(26, ca.Length - i - 1);
        }
        return result;
    }
    
    private int getLetterInteger(char c) {
        return (int)c - 64;
    }
}