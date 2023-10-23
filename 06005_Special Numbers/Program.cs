namespace _06005_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (number % i == 0 &&
                                number % j == 0 &&
                                number % k == 0 &&
                                number % l == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

//Write a program that reads an integer N from the user and generates all possible "special" numbers from 1111 to 9999. For a number to be "special", it must satisfy the following condition:
//•	N should be divisible by each of its digits without a remainder.
//Example: For N = 16, 2418 is a special number:
//•	16 / 2 = 8 without remainder
//•	16 / 4 = 4 without remainder
//•	16 / 1 = 16 without remainder
//•	16 / 8 = 2 without remainder
//HINT: If a number contains zero as any of its digits, it’s never a special number.
