//LeetCode
string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };

Console.WriteLine(MostWordsFound(sentences));
int MostWordsFound(string[] sentences)
{
    int max = 0;
    for (int i = 0; i < sentences.Length; i++)
    {
        int count = 1;
        for (int j = 0; j < sentences[i].Length; j++)
        {
            if (sentences[i][j] == ' ')
            {
                count++;
            }
        }
        if (count > max)
        {
            max = count;
        }
    }

    return max;
}