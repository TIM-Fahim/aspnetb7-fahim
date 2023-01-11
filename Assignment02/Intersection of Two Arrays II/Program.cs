int[] Intersect(int[] nums1, int[] nums2)
{
    Dictionary<int, int> frequency = new Dictionary<int, int>();
    List<int> result = new List<int>();

    for (int i = 0; i< nums1.Length; i++)
    {
        if (frequency.ContainsKey(nums1[i]))
        {
            frequency[nums1[i]]++;
        }
        else
        {
            frequency.Add(nums1[i], 1);
        }
    }
    for (int i = 0; i < nums2.Length; i++)
    {
        if (frequency.ContainsKey(nums2[i]) && frequency[nums2[i]] > 0)
        {
            result.Add(nums2[i]);
            frequency[nums2[i]]--;
        }
    }
    return result.ToArray();
}
int[] nums1 = { 4, 9, 5 };
int[] nums2 = { 9, 4, 9, 8, 4 };

int[] result = Intersect(nums1, nums2);

Array.ForEach(result, Console.WriteLine);