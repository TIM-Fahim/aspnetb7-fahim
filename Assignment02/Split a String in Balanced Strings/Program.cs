// LeetCode
Console.WriteLine(BalancedStringSplit("RLRRRLLRLL"));
int BalancedStringSplit(string s)
{
    if (string.IsNullOrEmpty(s))
    {
        return 0;
    }
    int start = 0;
    int end = 0;
    int count = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == 'L')
        {
            start++;
        }
        else
        {
            end++;
        }

        if (start == end)
        {
            count++;
        }
    }
    return count;
}
