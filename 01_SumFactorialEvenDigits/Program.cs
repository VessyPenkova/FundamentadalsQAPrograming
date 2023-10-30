using System.Collections.Immutable;

namespace _01_SumFactorialEvenDigits;

public class Program
{
    static void Main(string[] args)
    {
        int inputNumber = int.Parse(Console.ReadLine());
        string inputStr = inputNumber.ToString();
        int[] input = new int[inputStr.Length];

        for (int i = 0; i < inputStr.Length; i++)
        {
            string currentstring = inputStr[i].ToString();
            int currentNumber = int.Parse(currentstring);
            input[i] = currentNumber;
        }
            
        int n = input.Length;

        Console.WriteLine(CalculateEvenFactorial(input));

        static int CalculateEvenFactorial(int[] arr)
        {
            List<int> factorialsList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];

                if (currentNum % 2 == 0)
                {
                    int result = CalculateFactorial(currentNum);
                    arr[i] = result;
                    factorialsList.Add(result);
                }
            }
            return factorialsList.Sum();
        }
        static int CalculateFactorial(int number)
        {
            //5! = 1 * 2 * 3 * 4 * 5
            int fact = 1; //factorial
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            //calculated factorial in  fact
            return fact;
        }
    }
}

//Write a program that:
//•	Reads an integer number from the console
//•	Calculate sum of the factorials only on even digits of the given number
//•	Print the calculated sum





