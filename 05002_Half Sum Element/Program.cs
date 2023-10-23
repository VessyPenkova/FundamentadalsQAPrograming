namespace _05002_Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {

                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;
                if (inputNumber > max)
                {
                    max = inputNumber;
                }
            }
            int sumWithoutMaxNum = sum - max;
            if (max == sumWithoutMaxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}

//2.Element That Equals to the Sum of Others
//Write a program that reads n integer numbers entered by the user, and checks whether there is a number
//among them that is equal to the sum of all the others.
//•	If such an element exists, print "Yes" and on a new line "Sum = " + its value
//•	If there is no such element, print "No" and on a new line "Diff = " + the difference between the largest
//element and the sum of the others (absolute value).