//LeetCode
int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
int length = RemoveDuplicates(nums);
Console.WriteLine(length);

int RemoveDuplicates(int[] nums)
{
    int count = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[count] = nums[i];
            count++;
        }
    }
    if (nums == null || nums.Length ==0)
    {
        return 0;
    }

    return count;
    
}