int MinimumRounds(int[] tasks)
{
    var dict = new Dictionary<int, int>();
    var n = tasks.Length;
    var cnt = 0;
    
    for (var i = 0; i < n; i++)
    {
        if (!dict.ContainsKey(tasks[i])) dict.Add(tasks[i], 1);
        else dict[tasks[i]]++;
    }

    foreach (var value in dict.Values)
    {
        if (value == 1)
            return -1;

        cnt += (value % 3) switch
        {
            1 => 2 + (value - 4) / 3,
            2 => 1 + (value - 2) / 3,
            _ => value / 3
        };
    }

    return cnt;
}

Console.WriteLine(MinimumRounds(new int[]{ 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 }));
Console.WriteLine(MinimumRounds(new int[]{ 2, 3, 3 }));