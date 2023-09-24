namespace _04._Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysNumberPerBooknumber  = int.Parse(Console.ReadLine());

            var daysReeding = (numberOfPages / pagesPerHour / daysNumberPerBooknumber);

            Console.WriteLine(daysReeding);
        }
    }
}
//4.Mandatory Literature
//For the summer holidays, there are a certain number of books on Joro's list of mandatory literature.
//Since Joro prefers to play with friends outside, your task is to help him calculate how many hours a day
//he should devote to read the necessary literature.
//Input
//Read 3 lines from the console:
//1.Number of pages  in the current book – an integer in the range [1... 1000]
//2.Pages that he reads in 1 hour – an integer in the range [1... 1000]
//3.The number of days he needs to finish the book – an integer in the range [1... 1000]
//Hint: For the operands of integer types, the result of the /
//operator is of an integer type and equals the quotient of the two operands rounded towards zero.
//Output
//Print on the console the number of hours that Joro has to spend reading each day.
