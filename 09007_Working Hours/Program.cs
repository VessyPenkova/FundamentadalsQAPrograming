namespace _09007_Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int hourInput = int.Parse(Console.ReadLine());
           string dayOfTheWeek = Console.ReadLine();
           string[] workingDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
           int[] workingHours = { 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            if (workingDays.Contains(dayOfTheWeek) && workingHours.Contains(hourInput))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }

        }
    }
}

//Write a program that checks if the company's office is open:
//•	Reads an hour of the day V  (integer number) and a day of the week (string)
//•	The office's working hours are from 10 AM to 6 PM, Monday through Saturday, inclusive.
//o	Print "open", if the office is open in the given hour and day of the week
//o	Print "closed", if the office is closed in the given hour and day of the week
