using System.ComponentModel;

namespace _10001_Numbers_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int beginingOfLoop = int.Parse(Console.ReadLine());
           int endOfLoop = int.Parse(Console.ReadLine());
            for (int i = beginingOfLoop; i <= endOfLoop; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}

//Write a program that prints numbers in a given range:
//•	Reads two integer numbers from the console
//•	First integer number represents the start of the range
//•	Second integer number represents the end of the range
//•	Print the numbers in the given range (include start and end number), each on the new line

//Note: The first given integer will always be bigger than the second given integer.
