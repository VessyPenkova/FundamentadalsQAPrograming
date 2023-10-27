namespace _18001_Gauss__Trick_Arrays_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> output = new List<int>();
            for (int i = 0; i < input.Count / 2; i++)
            {
                int sum = input[0+ i] + input[input.Count - 1 -i];
                output.Add(sum);

            }
            if (input.Count % 2 != 0)
            {
                int number = input[input.Count / 2];
                output.Add(number);
            }
            Console.Write(String.Join(" ", output));
            //Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

//Write a program that:
//•	Reads a sequence with integer numbers from the console
//•	Sums all numbers in a list in the following order:
//first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last – n
