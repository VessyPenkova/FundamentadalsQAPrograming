namespace _09009_Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 0;
            for (int i = 0; i <=2; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum+= number;
            }

            int minutes = sum % 60;
            int hours = (sum - minutes)/60 ;

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}

//Three athletes finish in a certain number of seconds (between 1 and 50). 
//Write a program that:
//•	Read three integers - the athletes' times in seconds, from console
//•	 Calculate their total time in the format "minutes:seconds"
//Note: The seconds should be displayed with leading zero (2 as "02", 7 as "07", 35 as "35").
