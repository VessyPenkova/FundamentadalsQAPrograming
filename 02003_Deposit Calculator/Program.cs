namespace _02003_Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = Double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double annualInterestRate = Double.Parse(Console.ReadLine());

            double amount = depositAmount + depositMonths * ((depositAmount / 100 * annualInterestRate) / 12);
            Console.WriteLine(amount);
        }
    }
}