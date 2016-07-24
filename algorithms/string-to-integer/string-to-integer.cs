public class Solution {
    public int MyAtoi(string str) {
        
        int counter = 0;
        var ca = str.ToCharArray();
        for (int i = 0; i < ca.Length; i++) {
            if (ca[i] == ' ')
                counter++;
            else
                break;
        }
        str = str.Substring(counter, str.Length - counter);
        if (str == "")
            return 0;
        ca = str.ToCharArray();
        
        int firstDigitIndex = -1, endDigitIndex = -1;
        for (int i = 0; i < ca.Length; i++) {
            if (!isDigit(ca[i]) && ca[i] != '+' && ca[i] != '-')
                break;
            if (isDigit(ca[i]) && firstDigitIndex < 0) {
                firstDigitIndex = i;
                endDigitIndex = i;
            }
            else if (isDigit(ca[i]) && firstDigitIndex >= 0) {
                endDigitIndex = i;
            }
        }
        if (firstDigitIndex == -1 || endDigitIndex == -1)
            return 0;
        
        bool isSigned = false, isNegative = false;
        for (int i = 0; i < firstDigitIndex; i++) {
            if (!isDigit(ca[i]) && ca[i] != '+' && ca[i] != '-')
                return 0;
            if ((ca[i] == '+' && isSigned) || (ca[i] == '-' && isSigned))
                return 0;
            else if (ca[i] == '-' || ca[i] == '+') {
                isSigned = true;
                if (ca[i] == '-') 
                    isNegative = true;
            }
        }
        
        if (firstDigitIndex == 0)
            str = str.Substring(firstDigitIndex, endDigitIndex - firstDigitIndex + 1);
        else
            str = str.Substring(firstDigitIndex - 1, endDigitIndex - firstDigitIndex + 2);
        int result;
        try {
            result = int.Parse(str);
        }
        catch {
            if (!isNegative)
                return int.MaxValue;
            else
                return int.MinValue;
        }
        return result;
    }
    
    private bool isDigit(char c) {
        if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' ||
            c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
            return true;
        return false;
    }
}