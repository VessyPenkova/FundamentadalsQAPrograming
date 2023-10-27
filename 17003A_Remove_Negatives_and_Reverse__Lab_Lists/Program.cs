using System.ComponentModel;

namespace _17003A_Remove_Negatives_and_Reverse__Lab_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            //{10, -5, 7, 9, -33, 50}

            numbers.RemoveAll(number => number < 0);
            //{10, 7, 9, 50}

            numbers.Reverse();
            //{50, 9, 7, 10}

            //нямаме елементи
            if (numbers.Count == 0)
            {
                //празен списък
                Console.WriteLine("empty");
            }
            else
            {
                //списък пълен с числа
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

//Write a program that:
//•	Read a list of integers 
//•	Remove all negative numbers from it 
//•	Print the remaining elements in reversed order
//•	If there are no elements left in the list, print "empty"
