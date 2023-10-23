namespace _06002_Equal_Sum_of_Even_and_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();
                int oddsum = 0;
                int evenSum = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddsum += currentDigit;
                    }
                }
                if (oddsum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

//Write a program that reads two six-digit integers from the console in the range from 100000 to 300000.
//The first entered number will always be smaller than the second one.
//Print on one line, separated by spaces, all numbers that are between the two numbers red from the console and satisfy the following condition:

//The sum of the digits at even and odd positions must be equal.
//If there are no numbers that meet this condition, do not output any result on the console.