namespace _01006_Grades_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double input = double.Parse(Console.ReadLine());
            if (input >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}