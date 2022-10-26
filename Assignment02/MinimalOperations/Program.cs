//Leet Code

List<int> MinimalOperations(List<string> words)
{


    List<int> array = new List<int>();
    foreach (string a in words)
    {
        char[] cArray = a.ToCharArray();
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {

            for (int j = 1; j < a.Length; j++)
            {
                if (cArray[i] == cArray[j])
                {
                    count++;
                    break;
                }
            }
            break;

        }
        array.Add(count);
        count = 0;
    }

    return array;
}