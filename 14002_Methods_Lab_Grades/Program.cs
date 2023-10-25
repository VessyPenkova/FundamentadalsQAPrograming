namespace _14002_Methods_Lab_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            GetTheGardesInWords(input);
        }

        private static void GetTheGardesInWords(double input)
        {
            if (input >= 2.00 && input <= 3.00)
            {
                Console.WriteLine("Fail");
            }
            else if (input >= 3.00 && input <= 3.49)
            {
                Console.WriteLine("Average");
            }
            else if (input >= 3.50 && input <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (input >= 4.50 && input <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (input >= 5.50 && input <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}

//Write a program that:
//•	Reads a grade (floating-point number) from the console
//•	Create a method that receives a grade between 2.00 and 6.00
//•	Prints the corresponding grade in words
//o V       	"Fail" - If the grade is in range 2.00 – 2.99 (inclusively)
//o V          "Average" - If the grade is in range 3.00 – 3.49 (inclusively)
//o V           "Good" - If the grade is in range 3.50 – 4.49 (inclusively)
//o "Very good" - If the grade is in range 4.50 – 5.49 (inclusively)
//o "Excellent" - If the grade is in range 5.50 – 6.00 (inclusively)
