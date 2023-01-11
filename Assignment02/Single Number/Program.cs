
int SingleNumber(int[] nums)
{
    int result = 0;
    foreach (int num in nums)
    {
        result ^= num;
    }
    return result;
}

int[] nums = { 4, 1, 2, 1, 2 };

Console.WriteLine(SingleNumber(nums));