namespace _16005_Equal_Arrays__Lab_Arrays
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
            bool areBothArraysIdntical = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                int currentNumberFromTheArray1 = arr1[i];
                int currentNumberFromTheArray2 = arr1[i];
                if (currentNumberFromTheArray1 != currentNumberFromTheArray2)
                {
                    areBothArraysIdntical = false;
                }
            }
            if (areBothArraysIdntical == true)
            {
                Console.WriteLine("Arrays are identical.");
            }
            else if(areBothArraysIdntical != true)
            {
                Console.WriteLine("Arrays are not identical.");
            }
        }
    }
}

//Write a program that:
//•	Read two arrays with the same length from the console
//•	Check whether they are identical or not
//o	If the arrays are identical, print: "Arrays are identical."
//o If the arrays are NOT identical, print: "Arrays are not identical."
//Note: Arrays are identical if their elements are equal.
