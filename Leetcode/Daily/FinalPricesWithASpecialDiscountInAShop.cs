namespace Leetcode.Daily;

public class FinalPricesWithASpecialDiscountInAShop
{
    public int[] FinalPrices(int[] prices)
    {
        int len = prices.Length;

        for (int i = 0; i < len; i++)
        {
            int discount = 0;

            for (int j = i + 1; j < len; j++)
            {
                if (prices[i] >= prices[j])
                {
                    discount = prices[j];
                    break;
                }
            }

            prices[i] -= discount;
        }

        return prices;
    }
}
