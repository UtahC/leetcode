public class Solution {
    private Dictionary<int, int> dic = new Dictionary<int, int>() { { 1, 1 }, { 2, 2 } };
    public int ClimbStairs(int n) {
        if (n <= 0)
            return 0;
        else if (dic.ContainsKey(n))
            return dic[n];
        
        int n1 = 0, n2 = 0;
        if (dic.ContainsKey(n - 2))
            n1 = dic[n - 2];
        else {
            n1 = ClimbStairs(n - 2);
            dic[n - 2] = n1;
        }
        if (dic.ContainsKey(n - 1))
            n2 = dic[n - 1];
        else {
            n2 = ClimbStairs(n - 1);
            dic[n - 1] = n2;
        }
            
        return n1 + n2;
    }
}