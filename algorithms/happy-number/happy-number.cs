public class Solution {
    List<int> list = new List<int>();
    
    public bool IsHappy(int n) {
        int sum = 0;
        var ca = n.ToString().ToCharArray();
        for (int i = 0; i < ca.Length; i++) {
            int value = int.Parse(ca[i].ToString());
            sum += value * value;
        }
        if (n == sum) {
            if (sum == 1) {
                return true;
            }
            return false;
        }
        if (list.IndexOf(sum) >= 0)
            return false;
        else {
            list.Add(sum);
            return IsHappy(sum);
        }
        
    }
}