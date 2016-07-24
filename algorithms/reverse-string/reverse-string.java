public class Solution {
    public String reverseString(String s) {
        char[] originLetters = s.toCharArray();
        char[] reversedLetters = new char[originLetters.length];
        for (int i = 0, j = originLetters.length - 1; i < originLetters.length; i++, j--) {
            reversedLetters[j] = originLetters[i];
        }
        return new String(reversedLetters);
    }
}