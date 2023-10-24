namespace _11001_Decreasing_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i <= 1; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
//Write a program that:
//•	Reads an integer number N
//•	Print the numbers from N down to 1 (inclusively), each on separate line
//Note: N will always be bigger than 1.
