//LeetCode

string[] input = { "flower", "flow", "flight" };

string answer = "";

string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0 || strs == null)
    {
        return "";
    }
    else if (strs.Length == 1)
    {
        return strs[0];
    }
    
    for (int i = 0; i < input.Length; i++)
    {
        string temp ="";
        for (int j = 0; j < strs[i].Length; j++)
        {
            temp = strs[i].Substring(0,0);
        }
    }

    return null;
}