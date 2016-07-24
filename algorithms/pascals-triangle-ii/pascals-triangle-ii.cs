public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if (rowIndex == 0)
            return new List<int>() { 1 } as IList<int>;
        if (rowIndex == 1)
            return new List<int>() { 1, 1 } as IList<int>;
        IList<int> list = GetRow(rowIndex - 1);
        for (int i = 1; i < list.Count; i++) {
            list[i - 1] += list[i];
        }
        list.Insert(0, 1);
        return list;
    }
}