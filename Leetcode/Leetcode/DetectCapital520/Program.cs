bool DetectCapitalUse(string word)
{
    var cnt = word.Count(char.IsUpper);

    if (cnt == word.Length || cnt == 0)
        return true;

    if (cnt == 1 && char.IsUpper(word[0]))
        return true;

    return false;
}

Console.WriteLine(DetectCapitalUse("USA"));
Console.WriteLine(DetectCapitalUse("FlaG"));
Console.WriteLine(DetectCapitalUse("Flag"));
Console.WriteLine(DetectCapitalUse("g"));