namespace _08008_Sorted_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int tirdNumber = int.Parse(Console.ReadLine());
            if (tirdNumber > secondNumber && secondNumber > firstNumber)
            {
                Console.WriteLine("Ascending");
                
            }
            else if (firstNumber > secondNumber && secondNumber > tirdNumber)
            {
                Console.WriteLine("Descending");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
    }
}

//Write a program, which checks for sorted 3 numbers:
//•	Reads 3 integer numbers from the console 
//•	Based on the order of the numbers, print:
//o "Ascending" – if the numbers are in ascending order(from the smallest to the largest number)
//o "Descending" – if the numbers are in descending order(from the largest to the smallest number)
//o "Not sorted" – in any other case
//Note: Given numbers will not be equal.
