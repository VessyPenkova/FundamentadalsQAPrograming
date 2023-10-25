namespace _14001_Methods_Lab_Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            GetTheSignOfInteger(numberToCheck);
        }

        private static void GetTheSignOfInteger(int numberToCheck)
        {
            if (numberToCheck < 0)
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
//•	Reads an integer number N from the console
//•	Create a method that prints the sign of an entered number N:
//•	Print:
//o If the number is positive (N > 0): "The number {number} is positive."
//o If the number is negative (N < 0): "The number {number} is negative."
//o If the number is zero (N = 0): "The number {number} is zero."
