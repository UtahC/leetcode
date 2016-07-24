public class Solution {
    public int[] PlusOne(int[] digits) {
        int[] result = new int[digits.Length];
        digits[digits.Length - 1] += 1;
        for (int i = digits.Length - 1; i > 0; i--)
        {
            if (digits[i] >= 10)
            {
                digits[i] -= 10;
                digits[i - 1]++;
            }
        }
        Array.Copy(digits, result, digits.Length);
        if (digits[0] >= 10)
        {
            digits[0] -= 10;
            result = new int[digits.Length + 1];
            for (int i = 0; i < digits.Length; i++)
                result[i + 1] = digits[i];
            result[0] = 1;
        }
        return result;
    }
}