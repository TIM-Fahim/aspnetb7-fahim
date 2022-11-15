// LeetCode


int[] nums = { 1, 2, 3, 4 };

int[] result = RunningSum(nums);

foreach (int i in result)
{
    Console.WriteLine(i);
}
int[] RunningSum(int[] nums)
{
    for (int i = 1; i < nums.Length; i++)
    {
        nums[i] = nums[i] + nums[i - 1];
    }
    return nums;
 }
