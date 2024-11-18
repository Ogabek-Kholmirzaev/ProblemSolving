namespace Leetcode.TheLeetcodeBeginnersGuide;

public class NumberOfStepsToReduceANumberToZero {
    public int NumberOfSteps(int num) {
        int ans = 0;

        while (num > 0) {
            ans++;
            
            if (num % 2 == 0) {
                num /= 2;
                continue;
            }

            num--;
        }

        return ans;
    }
}