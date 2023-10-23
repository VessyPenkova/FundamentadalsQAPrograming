using System.ComponentModel;

namespace _07001_Freezing_Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());

            if (temperature <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}

//Write a program to check for freezing water, which:
//Reads a temperature in Celsius
//Checks whether the temperature is below zero
//Prints "Freezing weather!", if the temperature is equal or smaller than 0, otherwise print nothing
