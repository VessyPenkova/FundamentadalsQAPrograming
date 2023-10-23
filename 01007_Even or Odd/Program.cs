namespace _01007_Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numToCheck = int.Parse(Console.ReadLine());
            if (numToCheck % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}