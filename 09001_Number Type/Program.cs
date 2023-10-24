using System.ComponentModel;

namespace _09001_Number_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            if (numberToCheck <0 )
            {
                Console.WriteLine("negative");
            }
            else if (numberToCheck > 0)
            {
                Console.WriteLine("positive");
            }
            else if (numberToCheck == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}

//Write a program that:
//•	Reads an integer number from the console
//•	Based on the given number:
//o Print "negative", if the number is lower than zero
//o	Print "positive ", if the number is bigger than zero
//o	Print "zero ", if the number is equals to zero
