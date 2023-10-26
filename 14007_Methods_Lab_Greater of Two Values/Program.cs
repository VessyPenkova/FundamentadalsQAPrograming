using System;

string valueType = Console.ReadLine();

if (valueType == "int")
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(GreaterFromTwoNumbers(num1, num2));
}
else if (valueType == "char")
{
    char char1 = char.Parse(Console.ReadLine());
    char char2 = char.Parse(Console.ReadLine());

    Console.WriteLine(GreaterFromTwoChars(char1, char2));
}
else if (valueType == "string")
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();

    Console.WriteLine(GreaterFromTwoStrings(str1, str1));   
}

static string GreaterFromTwoStrings(string str1, string str2)
{
   
    if(str1.CompareTo(str2) < 0)
    {
       return  str1;
    }
    else
    {
        return str2;
    }
   
}
static char  GreaterFromTwoChars(char char1, char char2)
{
    char result = '0';
    if (char1 > char2)
    {
        result = char1;
    }
    else if (char1 < char2)
    {
        result = char2;
    }
    return result;
}
static int GreaterFromTwoNumbers(int num1, int num2)
{
    int result = 0;
    if (num1 > num2)
    {
        result = num1;
    }
    else if (num1 < num2)
    {
        result = num2;
    }
    return result;
}

//•	Reads a type (string) and two values of this type from the console
//•	Entered type can be one of the following values: "int", "char" or "string"
//•	Create methods which can compare int, char or string
//•	Return the biggest of the two values
