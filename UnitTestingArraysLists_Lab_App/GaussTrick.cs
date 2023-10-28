using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingArraysLists_Lab_App
{

    public class GaussTrick
    {
        public static List<int> SumPairs(List<int> numbers)
        {
            List<int> result = new();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }

            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }

            return result;
        }
    }

}
