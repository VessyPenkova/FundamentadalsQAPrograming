namespace _16001_Day_of_Week__Lab_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < daysOfTheWeek.Length-1; i++)
            {
                if (i == number )
                {
                    Console.WriteLine(daysOfTheWeek[i]);
                }
                if (number<0 || number > daysOfTheWeek.Length-1)
                {
                    Console.WriteLine("Invalid day!");
                }
            }
        }
    }
}

//Write a program that:
//•	Reads an integer number from the console
//•	If the number is in range [1…7] print:
//o   "Monday" for number 1
//o   "Tuesday" for number 2
//o   "Wednesday" for number 3
//o   "Thursday" for number 4
//o   "Friday" for number 5
//o   "Saturday" for number 6
//o   "Sunday" for number 7
//•	If the number is out of the given range print "Invalid day!"
