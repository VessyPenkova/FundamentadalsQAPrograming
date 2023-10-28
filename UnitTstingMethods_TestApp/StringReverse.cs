using System;
namespace UnitTstingMethods_TestApp
{
    public class StringReverse
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
