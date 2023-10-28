using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingArraysLists_Lab_App
{
    public class Reverse
    {
        public static string ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            return string.Join(" ", arr);
        }
    }

}
