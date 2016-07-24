public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();
        if (numRows == 0)
            return result;
        IList<int> row = new List<int>(){ 1 };
        result.Add(row);
        if (numRows == 1)
            return result;
        row = new List<int>(){1, 1};
        result.Add(row);
        if (numRows == 2)
            return result;
        result = Generate(numRows - 1);
        row = new List<int>(){1, 1};
        for (int i = 0; i < result.LastOrDefault().Count - 1; i++) {
            row.Insert(1, result.LastOrDefault()[i] + result.LastOrDefault()[i+1]);
        }
        result.Add(row);
        return result;
    }
}