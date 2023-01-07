using System.Security.Authentication.ExtendedProtection;
using System.Threading.Channels;

int CanCompleteCircuit(int[] gas, int[] cost)
{
    if (gas.Sum() < cost.Sum())
        return -1;

    var answer = 0;
    var currentGas = 0;

    for (int i = 0; i < gas.Length; i++)
    {
        currentGas += gas[i] - cost[i];

        if (currentGas < 0)
        {
            answer = i + 1;
            currentGas = 0;
        }
    }

    return answer;
}

Console.WriteLine(CanCompleteCircuit(new int[]{ 1, 2, 3, 4, 5 }, new int[]{ 3, 4, 5, 1, 2 }));
Console.WriteLine(CanCompleteCircuit(new int[]{ 2, 3, 4 }, new int[]{ 3, 4, 3 }));