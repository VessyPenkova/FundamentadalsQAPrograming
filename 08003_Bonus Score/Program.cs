namespace _08003_Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
            int bonus = 0;
            int result = 0;
            if (input >= 0 && input <= 3)
            {
                bonus = 5;
                result = input + bonus;
            }
            else if (input >= 4 && input <= 6)
            {
                bonus = 15;
                result = input + bonus;
            }
            else if (input >= 7 && input <= 9)
            {
                bonus = 20;
                result = input + bonus;
            }
            Console.WriteLine (result);
        }
    }
}
//Write a program that:

// •	Reads points(integer number) from the console
// •	Add bonus points to given points based on following:

//   -  If points are between 0 and 3 (inclusive), adds  5 to the given points
//   -  If points are between 4 and 6 (inclusive), adds 15 to the given points
//   -  If points are between 7 and 9 (inclusive), adds 20 to the given points
// •	Print final points after adding the bonus points
