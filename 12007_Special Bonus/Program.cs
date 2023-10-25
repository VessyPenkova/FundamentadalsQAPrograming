using System.ComponentModel;

namespace _12007_Special_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            
            int currentNumber = 0;

            while (true)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                
                if (inputNumber == stopNumber)
                {
                    Console.WriteLine(currentNumber*1.2);
                    break;
                }
                currentNumber = inputNumber;
            }
        }
    }
}

//Write a program to apply a 20% bonus for certain number: 
//•	Reads an integer number from the console: the "stop number"
//•	Keep reading integers until it finds the stop number
//•	When the stop number is found, increase the value of the previous number before it with 20% and print it
