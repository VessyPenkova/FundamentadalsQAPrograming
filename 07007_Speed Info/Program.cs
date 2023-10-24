namespace _07007_Speed_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            if (speed <= 30)
            {
                Console.WriteLine("Slow");
            }
            else if (speed > 30)
            {
                Console.WriteLine("Fast");
            }
        }
    }
}

//Write a program to check for fast / slow speed, which: 
//Reads a number (speed)
//Prints "Slow" if the number <= 30
//Prints "Fast" if the number > 30
