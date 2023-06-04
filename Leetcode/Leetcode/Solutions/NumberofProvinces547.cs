namespace Leetcode.Solutions;

public class NumberofProvinces547
{
    public List<int> Cities;

    public int FindCircleNum(int[][] isConnected)
    {
        Cities = new List<int>();
        var provinces = 0;

        for (var i = 0; i < isConnected.Length; i++)
        {
            if (!Cities.Contains(i))
            {
                Cities.Add(i);
                Solve(i, isConnected);
                provinces++;
            }
        }

        return provinces;
    }

    public void Solve(int cityNumber, int[][] isConnected)
    {
        for (var i = 0; i < isConnected.Length; i++)
        {
            if (isConnected[cityNumber][i] == 1 && !Cities.Contains(i))
            {
                Cities.Add(i);
                Solve(i, isConnected);
            }
        }
    }
}