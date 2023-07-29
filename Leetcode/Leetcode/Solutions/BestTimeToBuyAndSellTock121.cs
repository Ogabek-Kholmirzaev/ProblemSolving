namespace Leetcode.Solutions;

public class BestTimeToBuyAndSellTock121
{
    public static int MaxProfit(int[] prices)
    {
        int result = 0, min = prices[0];

        foreach (var price in prices)
        {
            min = Math.Min(min, price);

            if(price > min)
            {
                result = Math.Max(result, price - min);
            }
        }

        return result;
    }
}