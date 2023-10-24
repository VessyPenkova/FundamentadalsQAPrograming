namespace _12001_Power_Of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 2; i <= power; i*=n)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(result);
        }
    }
}

//Write a program to calculate number raising to a certain power:
//•	Reads an integer number n from the console
//•	Reads an integer number p which represents power from the console
//•	Print the result of n to the power of p
//Note: Don 't use Math.Pow(), use loops
