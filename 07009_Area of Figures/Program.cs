using System.ComponentModel;
using System;

namespace _07009_Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string figureType = Console.ReadLine();
            double area = 0;
            if (figureType == "square")
            {
                double sideSize = double.Parse(Console.ReadLine());
                area = sideSize*sideSize;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "rectangle")
            {
                double side1Size = double.Parse(Console.ReadLine());
                double side2Size = double.Parse(Console.ReadLine());
                area = side1Size*side2Size;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
                Console.WriteLine($"{area:f2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }
        }
    }
}

//Write a program to calculate figure area, which: 
//Reads the type of the figure (string)
//Valid figures are
//V + square,
//rectangle and
//circle
//Print "Invalid figure." otherwise
//Reads the size of the figure (one or two numbers)
//Prints the calculated area, formatted to the 2nd decimal

