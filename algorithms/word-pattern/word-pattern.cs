/*
test cases
------------------
""
""
"abba"
"dog cat cat dog"
"abba"
"dog cat cat fish"
"abba"
"dog dog dog dog"
*/
public class Solution {
    public bool WordPattern(string pattern, string str) {
        string[] strArray = str.Split(' ');
        char[] patternArray = pattern.ToCharArray();
        Dictionary<string, int> dic = new Dictionary<string, int>();
        if (strArray.Length != patternArray.Length) return false;
        for (int i = 0; i < patternArray.Length; i++) {
            for (int j = i; j < strArray.Length; j++) {
                if (patternArray[i] != patternArray[j]) continue;
                if (strArray[j] != strArray[i] || 
                  (dic.ContainsKey(strArray[j]) && patternArray[j] != patternArray[dic[strArray[j]]])) 
                    return false;
            }
            if (!dic.ContainsKey(strArray[i]))
                dic.Add(strArray[i], i);
        }
        return true;
    }
}