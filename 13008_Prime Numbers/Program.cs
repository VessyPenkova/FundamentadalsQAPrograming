namespace _13008_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int start = int.Parse(Console.ReadLine());
           int end = int.Parse(Console.ReadLine());         
            for (int i = start; i < end; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if ( i% j == 0)
                    {
                        isPrime = false;
                        break;
                    }                  
                }
                if (isPrime == true)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}

//Write a program that:
//•	Reads two integer numbers: start of the range and end of the range
//•	Print all prime numbers in given range
//Hint: A prime number is a positive integer greater than 1 that has exactly two distinct positive divisors: 1 and itself.
