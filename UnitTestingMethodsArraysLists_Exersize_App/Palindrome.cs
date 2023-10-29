using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMethodsArraysLists_Exersize_App
{
    public class Palindrome
    {
        public static bool IsPalindrome(List<string> words)
        {
            return words
                .Select(s => s.ToLower())
                .All(word => word.SequenceEqual(word.Reverse()));
        }
    }

}
