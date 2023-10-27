namespace _18002_Condense_Array_to_Number_Arrays_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            while (input.Count>1)
            {
                List<int> output = new List<int>();
                for (int i = 0; i < input.Count-1; i++)
                {
                    int num1 = input[i];
                    int num2 = input[i + 1];
                    int sum = num1 + num2;

                    output.Add(sum);
                }
                input = output;
            }
            Console.WriteLine(input[0]);
        }
    }
}

//Write a program that:
//      V       Read a sequence of integer numbers from the console
//•	Condense them by summing adjacent couples of elements until a single integer is obtained
//(i0 +i1 ) + (i1+i2[inout.Count-1])
//(2 + 10)  + (10 +3)
//  (12)    +   (13)  = 25
//Example: If we have 3 elements {2, 10, 3}. We sum the first two and the second two elements and obtain 
//	           {2+10, 10+3} = { 12, 13}. Then we sum again all adjacent elements and obtain {12+13} = { 25}.
