// LeetCode

Console.WriteLine(CheckIfPangram("thequickbrownfoxjumpsoverthelazydog"));
bool CheckIfPangram(string sentence)
{
    if (sentence.Length < 26)
    {
        return false;
    }
    else
    {
        var charArray = sentence.ToCharArray();
        var distinctChars = charArray.Distinct().ToArray();
        if (distinctChars.Length == 26)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
