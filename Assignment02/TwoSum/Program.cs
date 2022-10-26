//Leet Code

 static int[] TwoSum(int[] nums, int target)
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