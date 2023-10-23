namespace _04008_The_Greatest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int largestNumber = int.MinValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number >= largestNumber)
                {
                    largestNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(largestNumber);
        }
    }
}

//Write a program that reads integers entered by the user until the command "Stop" is received,
//and finds the largest number among them. Input one number per line.