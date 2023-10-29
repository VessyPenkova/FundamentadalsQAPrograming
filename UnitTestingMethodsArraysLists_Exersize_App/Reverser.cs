using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMethodsArraysLists_Exersize_App
{
    public class Reverser
    {
        public static string[] ReverseStrings(string[] arr)
        {
            return arr.Select(s => new string(s.Reverse().ToArray())).ToArray();
        }
    }
}
