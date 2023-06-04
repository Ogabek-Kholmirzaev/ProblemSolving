using Leetcode.Solutions;

var solution = new NumberofProvinces547();

Console.WriteLine(solution.FindCircleNum(new int[][]
{
    new []{1, 1, 0},
    new []{1, 1, 0},
    new []{0, 0, 1}
}));

Console.WriteLine(solution.FindCircleNum(new int[][]
{
    new []{1, 0, 0},
    new []{0, 1, 0},
    new []{0, 0, 1}
}));

Console.WriteLine(solution.FindCircleNum(new int[][]
{
    new []{ 1, 0, 0, 1 },
    new []{ 0, 1, 1, 0 },
    new []{ 0, 1, 1, 1 },
    new []{ 1, 0, 1, 1 }
}));