using System.ComponentModel;

namespace _15007_Factorial_Division_Exercise_Nested_Loops_Methods;

internal class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
      
        int factFirstNumber = CalculateFactorial(firstNumber);

        int factSecondNumber = CalculateFactorial(secondNumber);

        Console.WriteLine(factFirstNumber / factSecondNumber);

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
//•	Read two integers numbers from the console in range [1…10]
//•	Calculate the factorial of each number
//•	Divide the first calculated factorial by the second calculated factorial (integer division)
//•	Print the result of the division
