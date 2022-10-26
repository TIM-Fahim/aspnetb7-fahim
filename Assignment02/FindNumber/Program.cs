//Leet Code

static string FindNumber(List<int> arr, int k)
{
    string answer = "NO";

    foreach (int a in arr)
    {

        if (a == k)
        {
            answer = "YES";
            break;
        }
    }
    return answer;

}