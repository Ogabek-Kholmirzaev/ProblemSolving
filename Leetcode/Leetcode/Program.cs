var startDate = DateTime.Now;
var endDate = new DateTime(2033, 1, 1);
var cnt = 0;

for (var year = startDate.Year; year <= endDate.Year; year++)
{
    if (DateTime.IsLeapYear(year))
    {
        cnt++;
    }
}

if (DateTime.IsLeapYear(startDate.Year) && startDate > new DateTime(startDate.Year, 2, 29)) cnt--;
if (DateTime.IsLeapYear(endDate.Year) && endDate < new DateTime(endDate.Year, 2, 29)) cnt--;

Console.WriteLine(cnt);