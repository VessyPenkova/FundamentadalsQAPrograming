using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingArraysLists_Lab_App
{
    public class MaxNumber
    {
        public static int FindMax(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Input list is empty or null.");
            }

            return numbers.Max();
        }
    }
}
