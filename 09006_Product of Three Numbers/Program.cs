using System.ComponentModel;

namespace _09006_Product_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double firstNmber = double.Parse(Console.ReadLine());
            //double secondNmber = double.Parse(Console.ReadLine());
            //double tirdNmber = double.Parse(Console.ReadLine());

            int signCounter = 0;

            string result = "";

            for (int i = 0; i <=2; i++)
            {
                double firstNmber = double.Parse(Console.ReadLine());
                if (firstNmber < 0)
                {
                    signCounter++;
                }
                if (firstNmber == 0)
                {
                    result = "zero";
                    break;
                }
                else if (signCounter % 2 == 0)
                {
                    result = "positive";
                }
                else if (signCounter % 2 != 0)
                {
                    result = "negative";
                }
            }
            
            Console.WriteLine(result);
        }
    }
}

//Write a program that calculates the sign of the product of three numbers:
//•	Reads 3 real numbers from the console
//•	Print the sign of the product of the three given numbers: "positive", "negative" or "zero"
//Note: Try to do this without multiplying the numbers.
