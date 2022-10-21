    //using WellDevPracTice.Car;

    //Car<int> c = new Car<int>();

    //Car<Guid> gc = new Car<Guid>();
    public class Program
    { 
        public static void Main(string[] args)
        {
        string input = "AAABBCCCCDD";
        string output = "";
        char previous = input[0];
        int count = 1;
        for (int i = 1; i < input.Length; i++)
        {

            if (previous == input[i])
            {
                count++;
            }
            else
            {
                output += count.ToString() + previous;
                previous = input[i];
                count = 1;
            }

        }
        output += count.ToString() + previous;
        Console.WriteLine(output);
        //ans = ans + input[i] + count;
    }
    
    }