namespace _1_Magic_Numbers;

internal class Program
{
    static void Main(string[] args)
    {      
        int num = int.Parse(Console.ReadLine());
       
        bool isAllDigitPrime = true;

        List<int> primeNumberList = new List<int> { 2, 3, 5, 7 };
        List<int> result = new List<int>();
       
        for (int i = 1; i < num; i++)
        {
            int currentNumber = i;
            int digitSum = 0;

            while (currentNumber > 0)
            {
                int digit = currentNumber % 10;
                currentNumber = currentNumber / 10;
                if (primeNumberList.Contains(digit))
                {
                    digitSum += digit;
                }
                else
                {
                    isAllDigitPrime = false;
                    break;
                }
            }
            if (isAllDigitPrime && digitSum % 2 == 0)
            {
                result.Add(i);
                if (result.Count == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(String.Join(" ", result));
                }
               
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
//Write a program that:

//· Reads an integer number N from the console, always greater than 1

//· Print all magic numbers in range [1; N] -separated by single space

//· The number is magic when:

// -  All of its digits are prime numbers

// -  Sum of all digits is divisible by 2

//· If the are no such numbers print "no"