namespace _15003_Unique_PIN_Codes_Exercise_Nested_Loops_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max1 = int.Parse(Console.ReadLine());
            int max2 = int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());

            int[] secondDigitArray = { 2, 3, 5, 7 };

            for (int firstDigit = 2; firstDigit <= max1; firstDigit+=2)
            {
                for (int secondDigit  = 2; secondDigit <= max2; secondDigit++)
                {
                    for (int thirdDigit = 2; thirdDigit <= max3; thirdDigit+=2)
                    {
                        if (secondDigitArray.Contains(secondDigit))
                        {
                            Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");
                        }
                    }
                }
            }
        }
    }
}

//Write a program to generate PIN codes following certain rules:

//•	Read 3 integer digits:
//•	Generate unique 3-digit PIN codes, matching the following:

//int max1 - First digit:  [1 … max1] |  The first digit must be even
//int max2 - Second digit: [1 … max2] |  The second digit must be a prime number in the range [2…7]
//int max3 - Third digit:  [1 … max3] |  The third digit must be even

//•	Print the PIN codes, each on separate line
