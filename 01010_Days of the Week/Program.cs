namespace _01010_Days_of_the_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (number == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (number == 7)
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

//3.Check the following conditions:
//•	If day is 1, display "Monday" on the console.
//•	If day is 2, display "Tuesday" on the console.
//•	If day is 3, display "Wednesday" on the console.
//•	If day is 4, display "Thursday" on the console.
//•	If day is 5, display "Friday" on the console.
//•	If day is 6, display "Saturday" on the console.
//•	If day is 7, display "Sunday" on the console.
//•	If day is any other number, display "Error" on the console.
