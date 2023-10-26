namespace _16002_Sum_an_Array__Lab_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = (Console.ReadLine()).
                Split(" ").
                Select(int.Parse).
                ToArray();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}

//Write a program that:
//•	Read an array of integers (from a single line separated with a space)
//•	Print the sum of all elements in the given array
