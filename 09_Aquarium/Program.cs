using System.ComponentModel;
using System.Globalization;

namespace _09_Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthCM = int.Parse(Console.ReadLine());
            int widthCM = int.Parse(Console.ReadLine());
            int heightCM = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volumeCMFULL = lengthCM * widthCM * heightCM;
            double volume = volumeCMFULL / 1000;
            
            double litercapasity = volume - (volume / 100 * percentage);
            //double litercapasityRounded = Math.Round((litercapasity), 2);
            Console.WriteLine(litercapasity.ToString("f2"), CultureInfo.InvariantCulture);
        }
    }
}
//9.Aquarium
//For his birthday, Lyubomir received an aquarium in the shape of a parallelepiped.
//Initially, we read from the console in separate rows its dimensions
//– length, width and height in centimeters.
//It is necessary to calculate how many liters of water the aquarium will collect,
//if it is known that a certain percentage of its capacity is occupied by sand, plants, heater and pump. 
//One liter of water is equal to one cubic decimeter (1 l = 1 dm3). 
//Write a program that calculates the liters of water that are needed to fill the aquarium.


//Input
//From the console read 4 lines:
//  V 1.Length in cm – an integer number in the range [10 ... 500]
//  V 2.Width in cm – an integer number in the range [10 ... 300]
//  V 3.Height in cm – an integer number in the range [10... 200]
// V 4.Percentage – floating point number in the range [0.000 ... 100.000]


//Output
//Print one number on the console:
//•	the liters of water that the aquarium will collect, rounded to the second decimal place.
