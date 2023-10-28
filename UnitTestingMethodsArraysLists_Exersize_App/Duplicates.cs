using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMethodsArraysLists_Exersize_App
{
    public class Duplicates
    {
        public static int[] RemoveDuplicates(int[] numbers)
        {
            HashSet<int> uniqueNumbers = new();

            foreach (int number in numbers)
            {
                uniqueNumbers.Add(number);
            }

            return uniqueNumbers.ToArray();
        }
    }
}
