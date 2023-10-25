using System;

namespace _12006_Special_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();//as string(1, 3, 5, 6) Lenght of sequence is 3 strart form 0

            //1 is in position 0
            //3 is in position 1
            //5 is in position 2
            //6 is in position 3

            int number = int.Parse(sequence);//as number to check if it is devideble 

            bool isSpecialNumber = true;

            for (int i = 0; i < sequence.Length; i++)
            {
                int RealNumber = Convert.ToInt32(sequence[i]) - '0';// Convert the char on position[i]from the sequence as number from Ascii table

                if (number % RealNumber != 0)
                {
                    isSpecialNumber = false;
                }
                if (number % RealNumber == 0)
                {
                    isSpecialNumber = true;
                }
            }
            if (isSpecialNumber == true)
            {
                Console.WriteLine($"{number} is special");
            }
            else if(isSpecialNumber == false)
            {
                Console.WriteLine($"{number} is not special");
            }

        }
    }
}

//Write a program to check if given number is special: 
//•	Special numbers are divisible by all of their digits without remainder
//•	Reads an integer number and check whether it is a special number
//•	If the number IS special print: "{num} is special"
//•	If the number is NOT special print: "{num} is not special"
//Note: There will not be numbers with digit 0 in them.
