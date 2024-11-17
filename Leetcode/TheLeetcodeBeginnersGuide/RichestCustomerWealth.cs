namespace Leetcode.TheLeetcodeBeginnersGuide;

public class RichestCustomerWealth {
    public int MaximumWealth(int[][] accounts) {
        return accounts.Select(account => account.Sum()).Max();
    }
}