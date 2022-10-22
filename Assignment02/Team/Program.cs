int numberOfProblems = Convert.ToInt32(Console.ReadLine());

int answer = 0;

string[] inputs = new string[numberOfProblems];

for (int i = 0; i < numberOfProblems; i++)
{
    inputs[i] = Console.ReadLine();
}

foreach (string input in inputs)
{
    string[] split = input.Split(" ");
    //int[] splitInt = new int[split.Length];
    int sum = 0;
    for (int i = 0; i < split.Length; i++)
    {

        if (i == 2)
        {
            sum += Convert.ToInt32(split[i]);
            if (sum >= 2)
            {
                answer += 1;
            }
            sum = 0;
            break;
        }
        sum += Convert.ToInt32(split[i]);
    }
}
Console.WriteLine(answer);
