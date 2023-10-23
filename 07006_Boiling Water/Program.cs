using System.ComponentModel;

namespace _07006_Boiling_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int tempreture = int.Parse(Console.ReadLine());
            if (tempreture > 100)
            {
                Console.WriteLine("The water is boiling");
            }
            else
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}

//Write a program to check for boiling water, which: 
//Reads a number: the water temperature (in °C)
//Prints "The water is boiling" if the number > 100
//Prints "The water is not hot enough" in all other cases 