// LeetCode


int MaximumWealth(int[][] accounts)
{
    int Richest = 0;

    foreach (int[] account in accounts)
    {
        int Wealth = 0;

        foreach (int money in account)
        {
            Wealth += money;
        }

        if (Wealth > Richest)
        {
            Richest = Wealth;
        }
    }
    return Richest;
}