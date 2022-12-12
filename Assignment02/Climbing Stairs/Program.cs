int ClimbStairs(int n)
{
    int first = 1;
    int second = 1;
    int temp = 0; // 0 is the default value for int
    for (int i = 2; i <= n; i++)
    {
        temp = first;
        first += second;
        second = temp;
    }
    return first;
}

Console.WriteLine(ClimbStairs(5));