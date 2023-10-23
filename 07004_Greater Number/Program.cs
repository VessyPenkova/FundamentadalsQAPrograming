using System.ComponentModel;

namespace _07004_Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
           
            if (number1 > number2)
            {
                Console.WriteLine($"Greater number:  {number1}");
            }
            else
            {
                Console.WriteLine($"Greater number:  {number2}");
            }

            
        }
    }
}

//Write a program to find the greater of two numbers, which:
//Reads two integers
//Finds the greater number
//Prints "Greater number: " + the greater number
