namespace _18005_Bomb_Numbers_Arrays_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();
            List<int> bomb = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int bombNum = bomb[0];
            int bombPow = bomb[1];

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bombNum)
                {
                    int startIndex = i - bombPow;
                    int rangeToRemove = bombPow + bombPow + 1;
                    if (startIndex < 0)
                    {
                        rangeToRemove += startIndex;
                        startIndex = 0;
                    }
                    if (startIndex + bombPow > input.Count)
                    {
                        rangeToRemove = input.Count - startIndex-1;
                    }
                    input.RemoveRange(startIndex, rangeToRemove);
                    i = startIndex - 1;
                }
            }
            Console.WriteLine(input.Sum());
;        }
    }
}