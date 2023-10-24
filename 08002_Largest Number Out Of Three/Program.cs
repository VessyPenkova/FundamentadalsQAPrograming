namespace _08002_Largest_Number_Out_Of_Three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largestNumber = int.MinValue;

            for (int i = 0; i <=2; i++)
            {
                int firstNo = int.Parse(Console.ReadLine());
                //int secondNo = int.Parse(Console.ReadLine());
                //int tirthNo = int.Parse(Console.ReadLine());
                if (firstNo > largestNumber)
                {
                    largestNumber = firstNo;
                }
            }
            Console.WriteLine(largestNumber);
        }
    }
}

//Write a program that:
//•	Reads 3 integer numbers from the console
//•	Prints the largest number
