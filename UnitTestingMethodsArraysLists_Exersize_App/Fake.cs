using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMethodsArraysLists_Exersize_App
{
    public class Fake
    {
        public static char[] RemoveStringNumbers(char[]? arr)
        {
            if (arr is null)
            {
                throw new ArgumentException("Array can't be null.");
            }

            return arr.Where(c => !char.IsDigit(c)).ToArray();
        }
    }

}
