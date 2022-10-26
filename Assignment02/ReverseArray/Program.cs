//Leet Code

List<int> ReverseArray(List<int> arr)
{
    int length = arr[0];
    int[] array = arr.ToArray();
    int j = length;
    for (int i = 1; i < length / 2; i++)
    {
        int temp = array[i];
        //arr.Swap(arr[i], arr[j]);
        array[i] = array[j];
        array[j] = temp;
        j--;
    }
    arr = array.ToList();
    return arr;
}