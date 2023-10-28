namespace _18007_Zig_Zag_Arrays_Arrays_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            for (int i = 0; i < counter; i++)
            {
                List<int> numbersTogether = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToList();

              int number1 = numbersTogether[0];
              int number2 = numbersTogether[1];
                if ( i% 2 == 0)
                {
                    firstList.Add(number1);
                    secondList.Add(number2);

                }
                else
                {
                    firstList.Add(number2);
                    secondList.Add(number1);
                }
            }

            Console.WriteLine(String.Join(" ", firstList));
            Console.WriteLine(String.Join(" ", secondList));
        }
    }
}