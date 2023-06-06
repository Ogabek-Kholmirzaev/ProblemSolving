namespace Leetcode.Solutions;

public class CanMakeArithmeticProgressionFromSequence1502
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);

        var dif = arr[1] - arr[0];

        for (var i = 2; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] != dif)
                return false;
        }

        return true;
    }
}