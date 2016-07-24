public class Solution {
    public bool IsAnagram(string s, string t) {
        var s2 = s.ToList();
        var t2 = t.ToList();
        while (s2.Count > 0 && t2.Count > 0) {
            int index = t2.IndexOf(s2[0]);
            if (index == -1)
                break;
            s2.RemoveAt(0);
            t2.RemoveAt(index);
        }
        if (s2.Count == 0 && t2.Count == 0)
            return true;
        return false;
    }
}