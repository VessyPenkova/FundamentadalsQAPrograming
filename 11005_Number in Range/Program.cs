namespace _11005_Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumberValid = false;
            int number = int.Parse(Console.ReadLine());
            int theValidNumber = 0;
            while (true)
            {
                if (number >=0 && number <=100)
                {
                    isNumberValid = true;
                    theValidNumber = number;
                    break;
                }
                if (isNumberValid == false)
                {
                    number = int.Parse(Console.ReadLine());
                }             
            }
            Console.WriteLine(theValidNumber);
        }
    }
}

//Write a program to read a number in the range [1 … 100]:
//•	Read an integer number from the console
//•	Check if the number is in the range [1 … 100]
//o No(number is NOT in the range)  read a new number
//o   Yes(number is IN the range)  print the number and the program stops
