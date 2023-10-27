namespace _17003_Remove_Negatives_and_Reverse__Lab_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersInput = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();
            
            for (int i = 0; i < integersInput.Count; i++)
            {
                if (integersInput[i] < 0)
                {
                    integersInput.RemoveAt(i--);
                }
            }

            integersInput.Reverse();

            if (integersInput.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", integersInput));
            }

        }
    }
}

//Write a program that:
//•	Read a list of integers 
//•	Remove all negative numbers from it 
//•	Print the remaining elements in reversed order
//•	If there are no elements left in the list, print "empty"
