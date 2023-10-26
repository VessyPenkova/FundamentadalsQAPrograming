namespace _15004_Letter_Combinations_Exercise_Nested_Loops_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char excludedLetter = char.Parse(Console.ReadLine());
            int combinationCounter = 0;
            for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
            {
                for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
                {
                    for (char thirtLetter = startLetter; thirtLetter <= endLetter; thirtLetter++)
                    {
                        if (firstLetter != excludedLetter && secondLetter != excludedLetter && thirtLetter != excludedLetter)
                        {
                            Console.Write($"{firstLetter}{secondLetter}{thirtLetter} ");
                            combinationCounter ++;
                        }
                    }
                }
               
            }
            Console.WriteLine();
            Console.WriteLine(combinationCounter);
        }
    }
}


//Write a program to generate 3-letter combinations under certain conditions:
//•	Read
//  - startLetter
//  - endLetter 
//  - excludedLetter 
//•	Generate all combinations of 3 letters in the range [s…e], excluding x
//•	Print all combinations on the first line
//•	Print combinations count on the second line
