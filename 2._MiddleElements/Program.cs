namespace _2._MiddleElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            double sum = 0;
            int position = input.Length / 2;

            for (int i = 0; i <= input.Length / 2; i++)
            {
                if (i == position)
                {
                    int firstNum = input[i];
                    int secondNum = input[i - 1];
                    sum = firstNum + secondNum;
                }
               
            }
            Console.WriteLine($"{sum/2:f2}");
        }
    }
}