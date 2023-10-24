namespace _09005_Vacation_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accommodationType = Console.ReadLine();
            double countOfTheDays = double.Parse(Console.ReadLine());
            double finalAmount = 0;
            if (season == "Spring")
            {
                if (accommodationType == "Hotel")
                {
                    finalAmount = 30 * countOfTheDays - ((30 * countOfTheDays) / 100 * 20);
                }
                else if (accommodationType == "Camping")
                {
                    finalAmount = 10 * countOfTheDays - ((10 * countOfTheDays) / 100 * 20);
                }
            }
            else if (season == "Summer")
            {
                if (accommodationType == "Hotel")
                {
                    finalAmount = 50 * countOfTheDays ;
                }
                else if (accommodationType == "Camping")
                {
                    finalAmount = 30 * countOfTheDays ;
                }
            }
            else if (season == "Autumn")
            {
                if (accommodationType == "Hotel")
                {
                    finalAmount = 20 * countOfTheDays - ((20 * countOfTheDays) / 100 * 30);
                }
                else if (accommodationType == "Camping")
                {
                    finalAmount = 15 * countOfTheDays - ((15 * countOfTheDays) / 100 * 30);
                }
            }
            else if (season == "Winter")
            {
                if (accommodationType == "Hotel")
                {
                    finalAmount = 40 * countOfTheDays - ((40 * countOfTheDays)/ 100 * 10);
                }
                else if (accommodationType == "Camping")
                {
                    finalAmount = 10 * countOfTheDays - ((10 * countOfTheDays) / 100 * 10);
                }
            }

            Console.WriteLine($"{finalAmount:f2}");

        }
    }
}

//============================================== - Write a program, which calculates vacation expenses:
// Season  || Hotel  ||  Camling ||  Discount || - From the console read: v season(string)
//============================================== - v accommodation type(string) and v  count of the days (integer)
//Spring   ||    30  ||     10   ||    20%    || - Season will be one of the following: v"Spring",v"Summer", v"Autumn" and v"Winter"
//---------------------------------------------- - Accommodation type will be one of the following: "Hotel" and "Camping
//Summer   ||    50  ||     30   ||     0%    || - Based on the table below, you have to calculate expenses for the vacation 
//---------------------------------------------- - with the given accommodation type,season and count of the days. 
//Autumn   ||    20  ||     15   ||    30%    || - For the calculation: use price per night (extracted from the table below) 
//---------------------------------------------- - multiplied by count of the days.
//Winter   ||    40  ||     10   ||    10%    || - Print the total expenses, formatted to the second digit after the decimal point
//----------------------------------------------
