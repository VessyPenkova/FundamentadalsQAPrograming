using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMethodsArraysLists_Exersize_App
{
    public class Pattern
    {
        public static int[] SortInPattern(int[]? arr)
        {
            if (arr is null)
            {
                throw new ArgumentException("Array can't be null.");
            }

            Array.Sort(arr);

            int[] distinctList = arr.Distinct().ToArray();

            int[] result = new int[distinctList.Length];
            int left = 0;
            int right = distinctList.Length - 1;
            bool isLeftTurn = true;

            for (int i = 0; i < distinctList.Length; i++)
            {
                if (isLeftTurn)
                {
                    result[i] = distinctList[left];
                    left++;
                }
                else
                {
                    result[i] = distinctList[right];
                    right--;
                }

                isLeftTurn = !isLeftTurn;
            }

            return result;
        }
    }
}
