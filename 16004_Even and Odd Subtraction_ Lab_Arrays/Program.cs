namespace _16004_Even_and_Odd_Subtraction__Lab_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int evenSun = 0;
            int oddum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                if (currentNumber % 2 == 0)
                {
                    evenSun += currentNumber;
                }
                if (currentNumber % 2 != 0)
                {
                    oddum += currentNumber;
                }
            }
            Console.WriteLine (evenSun - oddum);
        }
    }
}

//Write a program that:
//•	Read an array of integers (from a single line separated with a space)
//•	Calculates the difference between the sum of the even and the sum of the odd numbers in an array
//•	Print the difference
