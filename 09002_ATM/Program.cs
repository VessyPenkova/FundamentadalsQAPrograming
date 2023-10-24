using System.ComponentModel;

namespace _09002_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());
            if (balance - withdraw >= 0)
            {
                Console.WriteLine("The withdraw was successful.");
            }
            else if (withdraw > limit)
            {
                Console.WriteLine("The limit was exceeded.");
            }
            else if (withdraw < limit)
            {
                Console.WriteLine("Insufficient availability.");
            }
        }
    }
}

//Write a program to simulate an ATM withdrawal:
//•	Reads 3 integer numbers which represents the following values: balance, withdraw and limit
//•	Based on the given input parameters:
//o Print "The withdraw was successful.", if the balance is enough
//o	Print "The limit was exceeded.", if the limit is exceeded
//o	Print "Insufficient availability.", if the balance isn't enough
