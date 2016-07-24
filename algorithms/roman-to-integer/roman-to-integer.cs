public class Solution
{
    public int RomanToInt(string s)
    {
        var dic = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        var ca = s.ToCharArray();
        var ia = new int[ca.Length];
        for (int i = 0; i < ca.Length; i++)
        {
            ia[i] = dic[ca[i]];
        }
        for (int i = 0; i < ia.Length - 1; i++)
        {
            for (int j = i + 1; j < ia.Length; j++)
            {
                if (ia[j] == ia[i] * 10 || ia[j] == ia[i] * 5)
                    ia[i] = ia[i] * (-1);
            }
        }
        return ia.Sum();
    }
}