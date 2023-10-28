namespace _18008_Array_Rotation_Arrays_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbersForRotation = Console.ReadLine()
          .Split(" ")
          .Select(int.Parse)
          .ToList();

            int rotationCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotationCount; i++)
            {
                int currentNumber = numbersForRotation[0];
                numbersForRotation.RemoveAt(0);
                numbersForRotation.Add(currentNumber);
            }
            Console.WriteLine(String.Join(" ", numbersForRotation));
        }
    }
}

//•	Reads sequence of integer numbers from the first line of the console
//•	Reads an integer number (rotations you have to perform) from the second line of the console
//•	Each rotation is when the first element goes at the end
//•	Print the resulting sequence
