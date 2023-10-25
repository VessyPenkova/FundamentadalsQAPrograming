namespace _12002_Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{input} x {j} = {input * j}");
            }
        }
    }
}

//Write a program that prints a multiplication table:
//•	Reads an integer number n from the console
//•	Print a multiplication table of size 10 for given integer n in the following format:
// "{n} x {i} = {result}" for each i in the range[1…10]
