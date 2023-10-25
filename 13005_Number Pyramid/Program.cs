namespace _13005_Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}

//Write a program that:
//V     •	Reads an integer number n from the console 
//•	Prints a pyramid of numbers as shown in the examples
