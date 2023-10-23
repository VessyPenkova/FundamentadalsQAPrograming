namespace _04006_Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int printNumber = 0;

            for (int i = 0; i <= n; i++)
            {
                printNumber = ((printNumber * 2) + 1);

                if (printNumber > n)
                {
                    break;
                }
                Console.WriteLine(printNumber);
            }
        }
    }
}