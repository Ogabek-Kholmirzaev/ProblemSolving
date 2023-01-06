int MaxIceCream(int[] costs, int coins)
{
    var cnt = 0;

    Array.Sort(costs);

    foreach (var cost in costs)
    {
        if (coins >= cost)
        {
            cnt++;
            coins -= cost;
        }
        else 
            break;
    }

    return cnt;
}

Console.WriteLine(MaxIceCream(new int[]{ 1, 3, 2, 4, 1 }, 7));
Console.WriteLine(MaxIceCream(new int[] { 10, 6, 8, 7, 7, 8 }, 5));
Console.WriteLine(MaxIceCream(new int[] { 1, 6, 3, 1, 2, 5 }, 20));