namespace Leetcode.TheLeetcodeBeginnersGuide;

public class FizzBuzzz {
    public IList<string> FizzBuzz(int n) {
        var ans = new string[n];

        for (var i = 1; i <= n; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                ans[i - 1] = "FizzBuzz";
                continue;
            }

            if (i % 3 == 0) {
                ans[i - 1] = "Fizz";
                continue;
            }

            if (i % 5 == 0) {
                ans[i - 1] = "Buzz";
                continue;
            }

            ans[i - 1] = i.ToString();
        }

        return ans;
    }
}