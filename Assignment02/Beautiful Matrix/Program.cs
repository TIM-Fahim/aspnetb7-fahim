
int[,] matrix = new int[5,5];

int answer = 0; 

for (int i = 0; i < 5; i++)
{
    string[] input = (Console.ReadLine().Split(' '));

    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = int.Parse(input[j]);
        if (matrix[i, j] == 1)
        {
            answer= (Math.Abs(i - 2) + Math.Abs(j - 2));
            
        }
    }
}
Console.WriteLine(answer);
