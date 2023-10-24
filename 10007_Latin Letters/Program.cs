namespace _10007_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char startForLoop = char.Parse(Console.ReadLine());
           char endForLoop = char.Parse(Console.ReadLine());
            for (int i = startForLoop; i <= endForLoop; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
//Write a program to print the Latin letters in certain range:
//•	Read two letters (chars), each on separate line
//•	Print all letters in the specified range inclusively
