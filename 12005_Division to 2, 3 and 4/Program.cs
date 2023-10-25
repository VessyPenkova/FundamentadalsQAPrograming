using System.ComponentModel;

namespace _12005_Division_to_2__3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfLoop = int.Parse(Console.ReadLine());

            int devideBytwoCounter = 0;
            int devideBythreeCounter = 0;
            int devideByfourCounter = 0;

            double percentageFor2 = 0;
            double percentageFor3 = 0;
            double percentageFor4 = 0;
            for (int i = 1; i <= endOfLoop; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    devideBytwoCounter++;
                }
                if (number % 3 == 0)
                {
                    devideBythreeCounter ++;

                }
                if (number % 4 == 0)
                {
                    devideByfourCounter++;
                }
                percentageFor2 = devideBytwoCounter*1.0 / endOfLoop*100;
                percentageFor3 = devideBythreeCounter*1.0 / endOfLoop*100;
                percentageFor4 = devideByfourCounter*1.0/ endOfLoop*100;
            }
            Console.WriteLine($"{percentageFor2:f2}%");
            Console.WriteLine($"{percentageFor3:f2}%");
            Console.WriteLine($"{percentageFor4:f2}%");
        }
    }
}

//Write a program to find statistics about division to 2, 3 and 4:
//•	Read an integer number N and N integers from the console
//•	Find in percentages how many of these integers can divide without a remainder to numbers 2, 3 and 4
//•	Print the percentages, formatted to the second decimal digit:
//o On the first line print percent of the numbers that are divisible by 2
//o	On the first line print percent of the numbers that are divisible by 3
//o	On the first line print percent of the numbers that are divisible by 4
