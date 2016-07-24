public class Solution {
    public string GetHint(string secret, string guess) {
        int A = 0, B = 0;
        bool[] isUsedSec = new bool[secret.Length];
        bool[] isUsedGue = new bool[guess.Length];
        for (int i = 0; i < secret.Length && i < guess.Length; i++) {
            isUsedSec[i] = false;
            isUsedGue[i] = false;
            if (secret[i] == guess[i]) {
                A++;
                isUsedSec[i] = true;
                isUsedGue[i] = true;
            }
        }
        for (int i = 0; i < guess.Length; i++) {
            int index = secret.IndexOf(guess[i]);
            if (index >= 0 && !isUsedGue[i]) {
                while (index >= 0) {
                    if (index >= 0 && !isUsedSec[index] && !isUsedGue[i]) {
                        B++;
                        isUsedSec[index] = true;
                        isUsedGue[i] = true;
                    }
                    index = secret.IndexOf(guess[i], index + 1);
                }
            }
        }
        return A + "A" + B + "B";
    }
}