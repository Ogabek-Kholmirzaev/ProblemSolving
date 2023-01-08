int MaxPoints(int[][] points) {
    int n = points.Length;

    if (n <= 2) return n;

    int ans = 2;

    for (int i = 0; i < n; i++) {
        for (int j = i + 1; j < n; j++) {
            int total = 2;
            for (int k = 0; k < n; k++) {
                if (k == i || k == j) continue;
                if ((points[j][1] - points[i][1]) * (points[i][0] - points[k][0]) == (points[i][1] - points[k][1]) * (points[j][0] - points[i][0])) {
                    total++;
                }
            }
            ans = Math.Max(ans, total);
        }
    }
    return ans;
}

Console.WriteLine(MaxPoints(new []
{
    new []{1, 1},
    new []{2, 2},
    new []{3, 3}
}));