using System.Runtime.Intrinsics.X86;

namespace _09004_Number_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumer = double.Parse(Console.ReadLine());
            double secondNumer = double.Parse(Console.ReadLine());
            char mathOperator = Char.Parse(Console.ReadLine());

            double result = 0;

            if (mathOperator == '*')
            {
                result = firstNumer * secondNumer;
            }
            else if (mathOperator == '/')
            {
                result = firstNumer / secondNumer;

            }
            else if (mathOperator == '-')
            {
                result = firstNumer - secondNumer;
            }
            else if (mathOperator == '+')
            {
                result = firstNumer + secondNumer;
            }
            Console.WriteLine ($"{firstNumer} {mathOperator} {secondNumer} = {result:f2}"); 
        }
    }
}
//10 + 12 = 22.00
//Write a program to evaluate operations, which:
//•	Reads 2 real numbers and math operator (string) from the console
//•	Possible given values for the math operator are: "+", "-", "*", "/"
//•	Apply the operator with given numbers
//•	Print output in the following format, where result is formatted to the second digit:
//"{N1} {operator} {N2} = {result}"
