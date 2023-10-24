namespace _11002_Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            while (true)
            {
                if (number% 2 != 0 )
                {
                    Console.WriteLine(number); break;
                }

                number = int.Parse(Console.ReadLine());
            }
        }
    }
}

//Write a program to enter an odd number:
//•	Read numbers from the console until an odd number is entered
//•	Print the odd number as output
