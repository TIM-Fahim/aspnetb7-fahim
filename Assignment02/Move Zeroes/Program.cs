 void MoveZeroes(int[] nums)
{
    int shiftCount = 0;
    for(int i=0;i<nums.Length;i++)
    {
        if (nums[i] == 0)
        {
          shiftCount++;
        }
        else if(shiftCount > 0)
        {
            nums[i-shiftCount] = nums[i];
            nums[i] = 0;
        }
    }
}