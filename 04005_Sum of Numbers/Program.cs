namespace _04005_Sum_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
                if (sum >= n)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}