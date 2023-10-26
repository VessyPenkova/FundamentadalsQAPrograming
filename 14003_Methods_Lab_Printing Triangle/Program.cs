namespace _14003_Methods_Lab_Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);

            static void PrintTriangle(int n)
            {
                for (int line = 1; line <= n; line++)
                    PrintLine(1, line);

                for (int line = n - 1; line >= 1; line--)
                    PrintLine(1, line);

            }

            static void PrintLine(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

