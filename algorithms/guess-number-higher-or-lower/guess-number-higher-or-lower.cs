/* The guess API is defined in the parent class GuessGame.
   @param num, your guess
   @return -1 if my number is lower, 1 if my number is higher, otherwise return 0
      int guess(int num); */

public class Solution extends GuessGame {
    public int guessNumber(int n) {
        int lowBoundary = 1, highBoundary = n, num = 0, result;
        while (lowBoundary < highBoundary) {
            num = lowBoundary + (highBoundary - lowBoundary) / 2;
            result = guess(num);
            if (result == 0)
                return num;
            else if (result < 0)
                highBoundary = num - 1;
            else if (result > 0)
                lowBoundary = num + 1;
        }
        return lowBoundary;
    }
}