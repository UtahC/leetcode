public class Solution {
    public int LengthOfLastWord(string s) {
        var words = s.Split(' ');
        int index = -1;
        for (int i = 0; i < words.Length; i++) {
            if (!string.IsNullOrEmpty(words[i]))
                index = i;
        }
        if (index < 0) 
            return 0;
        return words[index].Length;
    }
}