int MinStoneSum()
{
    var piles = new int[] {5, 4, 9};
    var k = 2;

    var arr = new int[10001];

    foreach (var pile in piles)
    {
        arr[pile]++;
    }

    for (var i = 10000; i >= 1; i--)
    {
        if (k > 0)
        {
            while (arr[i] > 0)
            {
                arr[i]--;
                k--;

                var index = i % 2 == 0 ? i / 2 : (i + 1) / 2;
                arr[index]++;
                
                if(k == 0) break;
            }
        }
        else
        {
            break;
        }
    }

    var ans = 0;
    
    for (var i = 1; i <= 10000; i++)
    {
        ans += arr[i] * i;
    }

    return ans;
}

Console.WriteLine(MinStoneSum());