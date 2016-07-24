/*
test case
0
1
13
15
20
25
30
35
40
2087
1808548329
*/

public class Solution {
    public int TrailingZeroes(int n) {
        ulong counter = 0;
        for (ulong i = 5; (ulong)n / i > 0; i *= 5) {
            counter += (ulong)n / i;
        }
        return (int)counter;
    }
}