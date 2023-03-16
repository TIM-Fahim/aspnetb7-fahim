//Leet Code

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];

    HashSet<int> hashSet = new HashSet<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        hashSet.Add(nums[i]);
    }
    int j = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        int tmp = target - nums[i];

        if (hashSet.Contains(tmp))
        {
            if (j > 1) { break; }
            result[j] = i;
            j++;
        }
    }

    return result;
}

int[] TwoSum2(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    throw new ArgumentNullException("Cannot find result");
}