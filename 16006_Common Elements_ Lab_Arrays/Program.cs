namespace _16006_Common_Elements__Lab_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();
            int[] arr2 = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();
            int currentNumber = 0;
            List<int> Diff = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                
                for (int j = 0; j < arr2.Length; j++)
                {
                     currentNumber = arr2[i];
                    if (arr1.Contains(currentNumber))
                    {                      
                        Diff.Add(currentNumber);
                    }
                }
            }

            List<int> noDupes = Diff.Distinct().ToList();
            for (int i = 0; i < noDupes.Count; i++)
            {
                Console.Write($"{noDupes[i]} ");
            }
        }
    }
}

//Write a program that:
//•	Read two integer arrays with the same length from the console
//•	Prints common elements in two arrays, space-separated
