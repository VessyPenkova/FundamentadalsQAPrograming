namespace _18003_Merging_Lists_Arrays_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> input1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> input2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int>reslt = new List<int>();
            if (input1.Count> input2.Count)
            {
                for (int i = 0; i <= input2.Count-1; i++)
                {
                    reslt.Add(input1[i]);
                    reslt.Add(input2[i]);   
                }
                for (int j = input2.Count ; j <= input1.Count - 1; j++)
                {
                    reslt.Add(input1[j]);
                }
            }
            else if (input2.Count > input1.Count)
            {
                for (int i = 0; i <= input1.Count-1; i++)
                {
                    reslt.Add(input1[i]);
                    reslt.Add(input2[i]);
                   
                }
                for (int j = input1.Count ; j <=input2.Count - 1; j++)
                {
                    reslt.Add(input2[j]);
                }
            }
            else if (input2.Count == input1.Count)
            {
                for (int i = 0; i <= input1.Count - 1; i++)
                {
                    reslt.Add(input1[i]);
                    reslt.Add(input2[i]);

                }
            }
            Console.WriteLine(string.Join(" ", reslt));
        }
    }
}

//Write a program that:
//•	Reads two sequences with integer numbers from the console
//•	Create a result list that contains the numbers from both of the sequences
//•	The first element should be from the first sequence, the second from the second sequence, and so on
//•	If the length of the two sequences is not equal, just add the remaining elements at the end of the sequence
