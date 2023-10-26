namespace _15002_Magic_Numbers_Exercise_Nested_Loops_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
           
            for (int firstNum = 1; firstNum <= 9; firstNum++)
            {
                for (int secondnum = 0; secondnum <= 9; secondnum++)
                {
                    for (int thirdNum = 0; thirdNum <= 9; thirdNum++)
                    {
                        if (firstNum * secondnum * thirdNum == inputNumber)
                        {
                            Console.Write($"{firstNum}{secondnum}{thirdNum} ");
                        }
                    }
                }
            }
        }       
    }
}
//From 100 to 999
//Magic if({firstNum}*{firstNum}*{firstNum} = inputNumber
//Write a program that:
//•	Reads an integer number N from the console
//•	Find all 3-digit magic numbers

//Note: A magic number is a three-digit number where the product of its digits equals the value of N.
//If you have a three-digit number abc, where a, b and c are its digits,
//it is considered a magic number of order N,  if a * b * c = N.
