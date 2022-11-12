// LeetCode
Console.WriteLine(LengthOfLastWord("Hello World"));
int LengthOfLastWord(string s)
{
    int count = 0;
    string word = "";
    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (s[i] != ' ')
        {
            if (count > 0)
                return count;
        }
        else
            count++;
    }
    //string ans = $"The last word is \"{word}\" with the length of {count}";
    return count;
}