bool CanJump()
{
    var nums = new int[] { 2, 3, 1, 1, 4 };

    var maxIndex = 0;

    for (var i = 0; i < nums.Length; i++)
    {
        if (i <= maxIndex)
        {
            maxIndex = Math.Max(maxIndex, i + nums[i]);
        }
        else
        {
            return false;
        }
    }

    return maxIndex >= nums.Length - 1;
}

Console.WriteLine(CanJump());