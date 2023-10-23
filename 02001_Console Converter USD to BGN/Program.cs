using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace _02001_Console_Converter_USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollarrate = double.Parse(Console.ReadLine());

            double euroAmmount = dollarrate * 1.79549;
        }
    }
}

//Write a program to convert US dollars (USD) to Bulgarian leva (BGN). 
//Use a fixed rate between dollar and lev:  1 USD = 1.79549 BGN. 