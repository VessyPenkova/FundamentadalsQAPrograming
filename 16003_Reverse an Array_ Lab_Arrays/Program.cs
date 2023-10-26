using static System.Formats.Asn1.AsnWriter;

namespace _16003_Reverse_an_Array__Lab_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int legthOFTheArray = int.Parse(Console.ReadLine());
            int[] arr = new int[legthOFTheArray];
            for (int i = 0; i < legthOFTheArray; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i =  legthOFTheArray-1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
//int i = n - 1; i >= 0; i--)

//Write a program that:
//•	Read an integer number N from the console
//•	After that read N integer numbers from the console, each on separate line
//•	Store the numbers in the array of integers
//•	Reverse the numbers in the array
//•	Print elements of the array on a single line, space-separated

