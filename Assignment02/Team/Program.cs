int numberOfProblem = Convert.ToInt32(Console.ReadLine());

int[][] problems = new int[numberOfProblem][];

for (int i = 0; i < numberOfProblem; i++)
{
    problems[i] = new int[4];
    int sum = 0;
    for (int j = 0; j < 4; j++)
    {
        if (j == 3)
        {
            problems[i][j] = sum;
            break;
        }
        problems[i][j] = Convert.ToInt32(Console.ReadLine());
        sum += problems[i][j];
    }
}
int answer = 0;
for (int i = 0; i < numberOfProblem; i++)
{
    if (problems[i][3] >= 2)
    {
        answer += 1;
    }
}

Console.WriteLine(answer);