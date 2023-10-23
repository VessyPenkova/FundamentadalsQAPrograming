using System.ComponentModel;

namespace _04009_The_Smallest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int smallertNumber = int.MaxValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number <= smallertNumber)
                {
                    smallertNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(smallertNumber);
        }
    }
}

//Write a program that reads integers entered by the user until the command "Stop" is received, 
//    and finds the smallest number among them. Input one number per line.