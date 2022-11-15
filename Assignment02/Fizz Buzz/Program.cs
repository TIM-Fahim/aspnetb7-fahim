// LeetCode

 IList<string> FizzBuzz(int n)
{
    List<string> FizzBuzz = new List<string>();

    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            FizzBuzz.Add("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            FizzBuzz.Add("Fizz");
        }
        else if (i % 5 == 0)
        {
            FizzBuzz.Add("Buzz");
        }
        else
        {
            FizzBuzz.Add(i.ToString());
        }
    }

    return FizzBuzz;
}