using System.ComponentModel;

namespace _12004_Vowel_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int endOfTheLoop = int.Parse(Console.ReadLine());
           
            int sum = 0;

            for (int i = 1; i <= endOfTheLoop; i++)
            {
                char toSum = char.Parse(Console.ReadLine());
                int amountOfTheChar = 0;
                if ( toSum  == 'a')
                {
                    amountOfTheChar = 1;
                }
                else if (toSum == 'e')
                {
                    amountOfTheChar = 2;
                }
                else if (toSum == 'i')
                {
                    amountOfTheChar = 3;
                }
                else if (toSum == 'o')
                {
                    amountOfTheChar = 4;
                }
                else if (toSum == 'u')
                {
                    amountOfTheChar = 5;
                }
                else 
                {
                    amountOfTheChar = 0;
                }
                sum+= amountOfTheChar;
            }
            Console.WriteLine(sum);
        }
    }
}

//Write a program to sum N vowels, according to the table below:
//•	Read an integer number N: the count of characters
//•	Read N characters and for each vowel character adds its value from the table to the result
