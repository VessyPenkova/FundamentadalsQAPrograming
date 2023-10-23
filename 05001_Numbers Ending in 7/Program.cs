namespace _05001_Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

//Write a program that prints the numbers in the range from 1 to 1000 that end with the digit 7.