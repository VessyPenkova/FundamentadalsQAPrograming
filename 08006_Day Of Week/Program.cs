namespace _08006_Day_Of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            if (dayOfTheWeek == 1 )
            {
                Console.WriteLine("Monday");
            }
            else if (dayOfTheWeek == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayOfTheWeek == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayOfTheWeek == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayOfTheWeek == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayOfTheWeek == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayOfTheWeek == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

//Write a program to print the day of week as words, which:
//•	Reads an integer number (the number will be in range [1… 7]) from the console
//•	Based on the value of the number, print:
//o If the given number is equals to 1 print the first day of the week, which is "Monday"
//o	If the given number is equals to 2 print the second day of the week, which is "Tuesday"
//o	If the given number is equals to 3 print the third day of the week, which is "Wednesday"
//o	If the given number is equals to 4 print the fourth day of the week, which is "Thursday"
//o	If the given number is equals to 5 print the fifth day of the week, which is "Friday"
//o	If the given number is equals to 6 print the sixth day of the week, which is "Saturday"
//o	If the given number is equals to 7 print the seventh day of the week, which is "Sunday"
//o	If the given number is out of the given range print "Error"
