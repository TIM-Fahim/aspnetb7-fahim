using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    public class FirstTry
    {
        public static void Main(string[] args)
        {

            int numberOfWords = Convert.ToInt32(Console.ReadLine());

            int[][] problems = new int[numberOfWords][];

            for (int i = 0; i < numberOfWords; i++)
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
            for (int i = 0; i < numberOfWords; i++)
            {
                if (problems[i][3] >= 2)
                {
                    answer += 1;
                }
            }

            Console.WriteLine(answer);
        }

        public void SecondTry()
        {
            int numberOfProblems = Convert.ToInt32(Console.ReadLine());

            int answer = 0;

            for (int i = 0; i < numberOfProblems; i++)
            {
                int count = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (j == 3)
                    {
                        if (count >= 2)
                        {
                            answer += 1;
                        }
                        break;
                    }
                    int input = Convert.ToInt32(Console.ReadLine());
                    count += input;
                }

            }

            Console.WriteLine(answer);
        }

        public void Accepted()
        {
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


        }
    }

}
