public class Solution {
    public int Reverse(int x) {
        bool isNegative = false;
        int result = 0;
        var ca = x.ToString().ToCharArray();
        
        char[] ca2 = new char[ca.Length];
        if (ca[0] == '-') {
            isNegative = true;
            ca2 = new char[ca.Length - 1];
        }
        for (int i = 0, j = ca.Length - 1;i < ca2.Length; i++, j--) {
            ca2[i] = ca[j];
        }
        try {
            result = int.Parse(new string(ca2));
        }
        catch {
            result = 0;
        }
        if (isNegative)
            return result * -1;
        return result;
    }
}