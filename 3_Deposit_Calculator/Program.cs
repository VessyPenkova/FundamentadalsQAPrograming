using System.ComponentModel;

namespace _3_Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = Double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double annualInterestRate = Double.Parse(Console.ReadLine());

            double amount = depositAmount + depositMonths * ((depositAmount /100 * annualInterestRate)/12);
            Console.WriteLine(amount);
        }
    }
}
//Write a program that calculates how much you will receive at the end of the deposit period at a certain interest rate. Use the following formula: 
//amount = deposited amount + term of deposit * (deposited amount * annual interest rate) / 12
//Input
//From the console read 3 lines:
//1.Deposited amount – real number in the range [100.00 ... 10000.00]
//2.Term of the deposit (in months) – an integer in the range [1... 12]
//3.Annual interest rate – real number in the range [0.00 ... 100.00]
//Output
//Print the amount on the console at the end of the term.
