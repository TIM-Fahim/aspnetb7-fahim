//Leet Code


int RemoveDuplicates(int[] nums)
{
    int[] a = new int[nums.Length];
    int j = 0;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[j] != nums[i])
        {
            nums[j] = nums[i];
            j++;
        }
    }
    return j;
}