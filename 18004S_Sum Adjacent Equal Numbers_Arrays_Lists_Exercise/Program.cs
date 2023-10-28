namespace _18004S_Sum_Adjacent_Equal_Numbers_Arrays_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();

            bool isItHaveDuplicatedValues = true;
            List<int> output = new List<int>();
            while (isItHaveDuplicatedValues == true)
            {
                for (int j = 0; j < input.Count - 1; j++)
                {
                    if (input[j] == input[j + 1])
                    {
                        //3361
                        int index = j;//i =0
                        int sum = input[j] + input[j + 1]; //3+3=6
                        output.Add(sum);
                        input.Insert(index, sum);  //Insert 6 at index[0] 63361                 
                        input.Remove(input[j + 1]);//Remove 3//-> On position[1] -> 6//6361
                        input.Remove(input[j + 1]);//Remove 3//-> On position[2] -> 6// 661                        
                    }
                    else if (input[j] != input[j + 1])
                    {
                        output.Add(input[j]);
                    }
                }
                input = output;
            }
            Console.Write(String.Join(" ", input));
        }
    }
}

//3 3 6 1
//3+3 = 6 at index 0 -> remuce 3 ans 3 => 6 6 1
//6 3 1
//Write a program that:
//•	Reads a sequence of integer numbers from the console
//•	Sum all adjacent equal numbers in a list of decimal numbers, starting from left to right
//o	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well
//o	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available)
