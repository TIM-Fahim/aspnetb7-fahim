// LeetCode
string jewels = "aA", stones = "aAAbbbb";
Console.WriteLine(NumJewelsInStones(jewels, stones));
int NumJewelsInStones(string jewels, string stones)
{
    int count = 0;

    for (int i = 0; i < stones.Length; i++)
    {
        for (int j = 0; j < jewels.Length; j++)
        {
            if (stones[i] == jewels[j])
            {
                count++;
            }
        }
    }
    return count;
}